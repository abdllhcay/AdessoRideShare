USE [AdessoRideShareDb]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 11/28/2020 19:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[X] [int] NOT NULL,
	[Y] [int] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trips]    Script Date: 11/28/2020 19:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trips](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OriginId] [int] NOT NULL,
	[DestinationId] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Capacity] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Remaining] [int] NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Trips] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Trips]  WITH CHECK ADD  CONSTRAINT [FK__Trips__From__25869641] FOREIGN KEY([OriginId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Trips] CHECK CONSTRAINT [FK__Trips__From__25869641]
GO
ALTER TABLE [dbo].[Trips]  WITH CHECK ADD  CONSTRAINT [FK__Trips__To__267ABA7A] FOREIGN KEY([DestinationId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Trips] CHECK CONSTRAINT [FK__Trips__To__267ABA7A]
GO
