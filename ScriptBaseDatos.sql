USE [LAFAST_gestor_de_reservas]
GO
/****** Object:  StoredProcedure [dbo].[cantidadDeAsientosOcupadosDeUnVueloEnUnMesX]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cantidadDeAsientosOcupadosDeUnVueloEnUnMesX]  @mes int , @numero_vuelo int  AS  SELECT count(*) from dbo.vuelos v  where month(v.fecha_salida_vuelo) = @mes AND v.id_asiento IS NOT NULL AND v.nro_vuelo = @numero_vuelo
GO
/****** Object:  StoredProcedure [dbo].[cantidadDeReservasRealizadasEnUnAñoX]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cantidadDeReservasRealizadasEnUnAñoX]


@year int

AS

SELECT count(*)
from dbo.reservas r
where  r.id_estado_reserva = 1
AND year(r.fecha_reserva) = @year
GO
/****** Object:  StoredProcedure [dbo].[cantidadDeReservasRealizadasEnUnMesYañoX]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cantidadDeReservasRealizadasEnUnMesYañoX]

@mes int , @year int

AS

SELECT count(*)
from dbo.reservas r
where month(r.fecha_reserva) = @mes
and  year(r.fecha_reserva) = @year
and r.id_estado_reserva = 2
GO
/****** Object:  StoredProcedure [dbo].[cantidadVuelosOrigenArgentinoPorMes]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cantidadVuelosOrigenArgentinoPorMes]  @mes int   AS  SELECT count(*)  from dbo.vuelos v inner join dbo.tramos t ON v.id_vuelo = t.id_vuelo 				  inner join dbo.aeropuertos a ON t.id_aeropuerto_origen = a.id_aeropuerto 				  inner join dbo.localidades l ON a.id_localidad_aeropuerto = l.id_localidad where month(v.fecha_salida_vuelo) = @mes AND l.id_pais = 1
GO
/****** Object:  StoredProcedure [dbo].[CodigoRecerva]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CodigoRecerva]

@cod int

as 

 SELECT 
     numero_documento_titular,
     fecha_reserva,
     fecha_salida 
     ,costo_total,costo_unitario ,
 asientos.fila,asientos.letra,aeropuertos.nombre_aeropuerto,a.nombre_aeropuerto 
FROM [LAFAST_gestor_de_reservas].[dbo].[reservas] 
 join [LAFAST_gestor_de_reservas].[dbo].detalle_reserva 
 on reservas.id_reserva = detalle_reserva.id_reserva 
 join [LAFAST_gestor_de_reservas].[dbo].asientos on asientos.id_asiento=detalle_reserva.id_asiento join 
 [LAFAST_gestor_de_reservas].[dbo].aeropuertos on detalle_reserva.id_aeropuerto_origen = aeropuertos.id_aeropuerto 
 join 
 [LAFAST_gestor_de_reservas].[dbo].aeropuertos a on detalle_reserva.id_aeropuerto_destino = a.id_aeropuerto
  where codigo = @cod
 order by fecha_salida;
GO
/****** Object:  StoredProcedure [dbo].[costoTotalPromedioDeReservasDuranteElAño]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[costoTotalPromedioDeReservasDuranteElAño]

@year int

as

SELECT avg(r.costo_total) as "Promedio"
FROM dbo.reservas r
where year(r.fecha_reserva) = @year
GO
/****** Object:  StoredProcedure [dbo].[EliminarAeropuerto]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarAeropuerto]
@nombre_aeropuerto varchar
as delete from aeropuertos where nombre_aeropuerto =@nombre_aeropuerto ; 
GO
/****** Object:  StoredProcedure [dbo].[gananciaGanadaPorReservaDuranteElAño]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[gananciaGanadaPorReservaDuranteElAño]

@year int

as

SELECT sum(r.costo_total) as "Ganancia"
FROM dbo.reservas r
where year(r.fecha_reserva) = @year
GO
/****** Object:  StoredProcedure [dbo].[gananciaTotalEnUnAñoXporMes]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gananciaTotalEnUnAñoXporMes]

@year int

as

select month(r.fecha_salida) AS "Mes", sum(r.costo_total) AS "Ganancia"
from dbo.reservas r
where year(r.fecha_salida) = @year
group by month(r.fecha_salida);

GO
/****** Object:  StoredProcedure [dbo].[historioVueos]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[historioVueos]  

@pais varchar(20)

as
select count(ae.[id_localidad_aeropuerto]) as "Cantidad" ,loc.[nombre_localidad] as "Aeropuerto" from  
   [dbo].[aeropuertos] ae right join [dbo].[tramos] v
on v.[id_aeropuerto_origen] = ae.[id_aeropuerto] 
   join [dbo].[localidades] loc on ae.[id_localidad_aeropuerto] =loc.[id_localidad]
    join [dbo].[paises] p on p.[id_pais]=loc.[id_pais]
   where p.[nombre_pais] like '%'+@pais+'%'
 group by loc.[nombre_localidad];
GO
/****** Object:  StoredProcedure [dbo].[listadoDeAeropuertosYlocalidadDestinoPorPais]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[listadoDeAeropuertosYlocalidadDestinoPorPais]

@id_pais varchar(20)

as

select a.nombre_aeropuerto as "Aeropuerto", l.nombre_localidad as "Localidad"
from dbo.aeropuertos a INNER JOIN dbo.localidades l ON a.id_localidad_aeropuerto = l.id_localidad
					   INNER JOIN dbo.paises p ON l.id_pais = p.id_pais
where p.[nombre_pais] like '%'+@id_pais+'%'
GO
/****** Object:  StoredProcedure [dbo].[pasajerosConMenorCantidadDeMillasQue]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pasajerosConMenorCantidadDeMillasQue]

@cantidad int

as

SELECT p.apellido as "Apellido", p.nombre as "Nombre", p.cantidad_millas as "Millas"
FROM dbo.pasajero p
where p.cantidad_millas < @cantidad
GO
/****** Object:  StoredProcedure [dbo].[promedioPorMesEnUnAñoX]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[promedioPorMesEnUnAñoX]

@year int

as

select month(r.fecha_salida) AS "Mes", avg(r.costo_total) AS "Promedio"
from dbo.reservas r
where year(r.fecha_salida) = @year
group by month(r.fecha_salida)
GO
/****** Object:  StoredProcedure [dbo].[reservasPorMes]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reservasPorMes]

@mes int

as

select (count(*)) as "Cantidad"
from dbo.reservas r
where month(r.fecha_salida) = @mes
GO
/****** Object:  Table [dbo].[aeropuertos]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[aeropuertos](
	[id_aeropuerto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_aeropuerto] [varchar](50) NOT NULL,
	[id_localidad_aeropuerto] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[asientos]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asientos](
	[id_asiento] [int] IDENTITY(1,1) NOT NULL,
	[letra] [varchar](50) NULL,
	[fila] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[avion]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[avion](
	[id_avion] [int] IDENTITY(1,1) NOT NULL,
	[id_modelo_avion] [int] NOT NULL,
	[capacidad] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[categoria_pasajero]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria_pasajero](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[desc_categoria] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_reserva]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_reserva](
	[id_reserva] [int] NOT NULL,
	[id_tipo_documento_titular_reserva] [int] NOT NULL,
	[numero_documento_titular_reserva] [int] NOT NULL,
	[id_tipo_documento_pasajero] [int] NOT NULL,
	[numero_documento_pasajero] [int] NOT NULL,
	[costo_unitario] [int] NOT NULL,
	[id_aeropuerto_origen] [int] NOT NULL,
	[id_aeropuerto_destino] [int] NOT NULL,
	[id_asiento] [int] NULL,
	[id_vuelo] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[estado_reserva]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estado_reserva](
	[id_estado_reserva] [int] NOT NULL,
	[desc_estado_reserva] [varchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[localidades]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[localidades](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre_localidad] [varchar](50) NULL,
	[id_pais] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marcas]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marcas](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[desc_marca] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modelo_avion]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modelo_avion](
	[id_modelo_avion] [int] IDENTITY(1,1) NOT NULL,
	[desc_modelo_avion] [varchar](50) NULL,
	[id_marca] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[paises]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[paises](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[nombre_pais] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pasajero]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pasajero](
	[id_tipo_documento] [int] NOT NULL,
	[numero_documento] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[id_categoria_pasajero] [int] NOT NULL,
	[usuario] [varchar](50) NULL,
	[clave] [varchar](50) NULL,
	[cantidad_millas] [int] NULL,
	[calle] [varchar](50) NULL,
	[numero_calle] [int] NULL,
	[id_localidad_pasajero] [int] NOT NULL,
	[fecha_nacimiento] [date] NULL,
UNIQUE NONCLUSTERED 
(
	[numero_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_tipo_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reservas]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reservas](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_documento_titular] [int] NOT NULL,
	[numero_documento_titular] [int] NOT NULL,
	[fecha_reserva] [date] NOT NULL,
	[fecha_salida] [date] NOT NULL,
	[id_estado_reserva] [int] NOT NULL,
	[costo_total] [int] NOT NULL,
	[observacion] [varchar](1024) NULL,
	[codigo] [int] NULL,
 CONSTRAINT [PK_reservas] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC,
	[id_tipo_documento_titular] ASC,
	[numero_documento_titular] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tarifas]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tarifas](
	[id_tarifa] [int] IDENTITY(1,1) NOT NULL,
	[clase_tarifa] [varchar](50) NULL,
	[precio_tarifa] [int] NULL,
	[impuesto_tarifa] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_documento]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_documento](
	[id_tipo_documento] [int] IDENTITY(1,1) NOT NULL,
	[desc_tipo_doc] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tramos]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tramos](
	[id_aeropuerto_origen] [int] NOT NULL,
	[id_aeropuerto_destino] [int] NOT NULL,
	[distancia_tramo] [int] NOT NULL,
	[id_vuelo] [int] NULL,
	[id_avion] [int] NULL,
	[fecha_salida_vuelo] [date] NULL,
	[duracion] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[correo_usuario] [varchar](250) NOT NULL,
	[pass_usuario] [varchar](250) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vuelos]    Script Date: 26/06/2019 21:05:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vuelos](
	[id_vuelo] [int] IDENTITY(1,1) NOT NULL,
	[nro_vuelo] [int] NOT NULL,
	[id_avion] [int] NOT NULL,
	[fecha_salida_vuelo] [date] NOT NULL,
	[id_asiento] [int] NULL,
	[id_tipo_documento_pasajero] [int] NULL,
	[numero_documento_pasajero] [int] NULL,
	[id_tarifa_vuelo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_vuelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
