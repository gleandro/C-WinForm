CREATE DATABASE FACTURA
GO
USE [FACTURA]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nom_cli] [varchar](50) NULL,
	[apel_cli] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle](
	[NumFac] [int] NOT NULL,
	[CodPro] [int] NULL,
	[PrecioVen] [float] NULL,
	[CanVen] [float] NULL,
 CONSTRAINT [PK_Detalle] PRIMARY KEY CLUSTERED 
(
	[NumFac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[NumFac] [int] NOT NULL,
	[FecFac] [date] NULL,
	[CodCli] [int] NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[NumFac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nom_prod] [varchar](50) NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nom_usu] [varchar](50) NULL,
	[account] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[bl_admin] [bit] NULL,
	[foto] [varchar](500) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([id_cliente], [nom_cli], [apel_cli]) VALUES (1, N'Giancarlo', N'Leandro')
GO
INSERT [dbo].[Clientes] ([id_cliente], [nom_cli], [apel_cli]) VALUES (2, N'Tania', N'Alvarado')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

GO
INSERT [dbo].[Productos] ([id_producto], [nom_prod], [precio]) VALUES (1, N'ITALIKA RT 250 SPORT', 10500)
GO
INSERT [dbo].[Productos] ([id_producto], [nom_prod], [precio]) VALUES (2, N'Pulsar 180', 9800)
GO
INSERT [dbo].[Productos] ([id_producto], [nom_prod], [precio]) VALUES (3, N'TVS APACHE RTR 180', 9500)
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([id_usuario], [nom_usu], [account], [password], [bl_admin], [foto]) VALUES (1, N'Giancarlo', N'gleandro', N'123456', 1, N'C:\Users\Giancarlo Leandro\Documents\Visual Studio 2017\Projects\WinForm\Login\Login\Resources\admin.png')
GO
INSERT [dbo].[Usuario] ([id_usuario], [nom_usu], [account], [password], [bl_admin], [foto]) VALUES (2, N'Tania', N'talvarado', N'123456', 0, N'C:\Users\Giancarlo Leandro\Documents\Visual Studio 2017\Projects\WinForm\Login\Login\Resources\user.png')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
/****** Object:  StoredProcedure [dbo].[DetailFact]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DetailFact] @NumFact int

as


select 
f.*,d.PrecioVen,d.CanVen,c.nom_cli,p.nom_prod,d.PrecioVen*d.CanVen as importe


from Facturas f inner join Detalle d on f.NumFac=d.NumFac
inner join Productos p on p.id_producto=d.CodPro
inner join Clientes c on f.CodCli=c.id_cliente


where f.NumFac = @NumFact
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETECLIENT]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_DELETECLIENT]

@id_cliente int

as

--Eliminar Cliente
delete from Clientes where id_cliente=@id_cliente

GO
/****** Object:  StoredProcedure [dbo].[SP_DELETEPRODUCT]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_DELETEPRODUCT]

@id_producto int

as

--Eliminar Producto
delete from Productos where id_producto=@id_producto

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATEDETAIL]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_UPDATEDETAIL] @NumFac int, @CodPro int, @PrecioVen float, @CanVen float

as

insert into Detalle(NumFac,CodPro,PrecioVen,CanVen) values(@NumFac,@CodPro,@PrecioVen,@CanVen)
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATEFACT]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_UPDATEFACT] @CodCli int

as

declare @Numfac int 

select @Numfac = MAX(NumFac) from Facturas

if @Numfac is null set @Numfac=0
set @Numfac = @Numfac + 1;

insert into Facturas(NumFac,FecFac,CodCli) values (@Numfac,GETDATE(),@CodCli)

select * from Facturas where NumFac=@Numfac
 
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATEINSERTCLIENT]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_UPDATEINSERTCLIENT]

@id_cliente int,@nom_cli varchar(50),@ape_cli varchar(50)

as

--Inserta Cliente
if	NOT EXISTS (SELECT id_cliente from Clientes where id_cliente=@id_cliente)
Insert into Clientes(nom_cli,apel_cli) values(@nom_cli,@ape_cli)

else
--Actualiza Cliente
update Clientes set nom_cli=@nom_cli,apel_cli=@ape_cli where id_cliente=@id_cliente

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATEINSERTPRODUCT]    Script Date: 02/06/2017 11:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_UPDATEINSERTPRODUCT]

@id_producto int,@nom_prod varchar(50),@precio float

as

--Inserta Producto
if	NOT EXISTS (SELECT id_producto from Productos where id_producto=@id_producto)
Insert into Productos(nom_prod,precio) values(@nom_prod,@precio)

else
--Actualiza Producto
update Productos set nom_prod=@nom_prod,precio=@precio where id_producto=@id_producto

GO
