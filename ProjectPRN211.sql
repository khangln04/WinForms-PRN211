USE [ProjectPRN211]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 3/21/2024 10:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[admin_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[phone] [nvarchar](25) NULL,
	[username] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 3/21/2024 10:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[phone] [varchar](25) NOT NULL,
	[address] [nvarchar](255) NOT NULL,
	[username] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[status] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_detail]    Script Date: 3/21/2024 10:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_detail](
	[orderdetail_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NULL,
	[customer_id] [int] NULL,
	[product_id] [int] NULL,
	[product_name] [nvarchar](255) NULL,
	[image] [varchar](200) NULL,
	[list_price] [float] NULL,
	[quantity_order] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderdetail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 3/21/2024 10:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[name_receiver] [nvarchar](255) NOT NULL,
	[phone_receiver] [nvarchar](20) NOT NULL,
	[address_receiver] [nvarchar](500) NOT NULL,
	[price] [float] NOT NULL,
	[date] [date] NOT NULL,
	[status] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK__orders__46596229E03566A4] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 3/21/2024 10:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [nvarchar](255) NULL,
	[description] [nvarchar](255) NOT NULL,
	[image] [nvarchar](200) NOT NULL,
	[list_price] [float] NOT NULL,
	[discount] [float] NOT NULL,
	[category_name] [nvarchar](255) NULL,
	[status] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[admin] ON 

INSERT [dbo].[admin] ([admin_id], [name], [phone], [username], [password]) VALUES (1, N'Lê Văn A', N'0902121881', N'admin', N'123')
INSERT [dbo].[admin] ([admin_id], [name], [phone], [username], [password]) VALUES (5, N'Nguyen Thi C', N'0147852369', N'admin2', N'123456')
SET IDENTITY_INSERT [dbo].[admin] OFF
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([customer_id], [name], [phone], [address], [username], [password], [status]) VALUES (1, N'Lê Ngọc Khang123', N'0123456789', N'Đan Phượng - Hà Nội', N'customer', N'123', N'Active')
INSERT [dbo].[customer] ([customer_id], [name], [phone], [address], [username], [password], [status]) VALUES (22, N'quynh', N'0321654987', N'Thanh Hoa', N'quynh', N'123456', N'Deactivate')
INSERT [dbo].[customer] ([customer_id], [name], [phone], [address], [username], [password], [status]) VALUES (24, N'duy', N'0147852369', N'Thanh Hoa', N'duy', N'123456', N'Active')
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[order_detail] ON 

INSERT [dbo].[order_detail] ([orderdetail_id], [order_id], [customer_id], [product_id], [product_name], [image], [list_price], [quantity_order]) VALUES (6, 2, 1, 3, N'LG GRAM 17ZD90R-G.AX73A5 (256GB/GREY)', N'latop.jpg', 10000, 1)
INSERT [dbo].[order_detail] ([orderdetail_id], [order_id], [customer_id], [product_id], [product_name], [image], [list_price], [quantity_order]) VALUES (7, 2, 1, 2, N'Denim shirt', N'denimshirt.jpg', 2000, 1)
SET IDENTITY_INSERT [dbo].[order_detail] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([order_id], [customer_id], [name_receiver], [phone_receiver], [address_receiver], [price], [date], [status]) VALUES (2, 1, N'Đỗ Văn Đạtt', N'0902121881', N'Đan Phượng - Hà Nội', 13000, CAST(N'2023-06-24' AS Date), N'Wait')
INSERT [dbo].[orders] ([order_id], [customer_id], [name_receiver], [phone_receiver], [address_receiver], [price], [date], [status]) VALUES (3, 1, N'Đỗ Văn Đạtt', N'0902121881', N'Đan Phượng - Hà Nội', 12000, CAST(N'2023-06-24' AS Date), N'Process')
INSERT [dbo].[orders] ([order_id], [customer_id], [name_receiver], [phone_receiver], [address_receiver], [price], [date], [status]) VALUES (7, 1, N'Lê Ngọc Khang', N'0123456789', N'Đan Phượng - Hà Nội', 0, CAST(N'2024-03-18' AS Date), N'Process')
INSERT [dbo].[orders] ([order_id], [customer_id], [name_receiver], [phone_receiver], [address_receiver], [price], [date], [status]) VALUES (8, 1, N'Lê Ngọc Khang', N'0123456789', N'Đan Phượng - Hà Nội', 0, CAST(N'2024-03-18' AS Date), N'Process')
INSERT [dbo].[orders] ([order_id], [customer_id], [name_receiver], [phone_receiver], [address_receiver], [price], [date], [status]) VALUES (19, 1, N'Lê Ngọc Khang123', N'0123456789', N'Đan Phượng - Hà Nội', 0, CAST(N'2024-03-21' AS Date), N'Wait')
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([product_id], [product_name], [description], [image], [list_price], [discount], [category_name], [status]) VALUES (1, N'Hoodie Boxy', N'Made in VietNam', N'hoodieboxy.jpg', 1000, 0.2, N'Garment', N'Stocking')
INSERT [dbo].[product] ([product_id], [product_name], [description], [image], [list_price], [discount], [category_name], [status]) VALUES (2, N'Denim shirt', N'Made in Korea', N'denimshirt.jpg', 2000, 0.4, N'Garment', N'Stocking')
INSERT [dbo].[product] ([product_id], [product_name], [description], [image], [list_price], [discount], [category_name], [status]) VALUES (3, N'LG GRAM 17ZD90R-G.AX73A5 (256GB/GREY)', N'Made in America', N'latop.jpg', 1500, 0.2, N'Technology', N'Stocking')
INSERT [dbo].[product] ([product_id], [product_name], [description], [image], [list_price], [discount], [category_name], [status]) VALUES (5, N't shirt Nike', N'Made in VietNam', N'nike.jpg', 2050, 0.2, N'Fashion', N'Stocking')
SET IDENTITY_INSERT [dbo].[product] OFF
GO
ALTER TABLE [dbo].[order_detail]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[customer] ([customer_id])
GO
ALTER TABLE [dbo].[order_detail]  WITH CHECK ADD  CONSTRAINT [FK__order_det__order__52593CB8] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
GO
ALTER TABLE [dbo].[order_detail] CHECK CONSTRAINT [FK__order_det__order__52593CB8]
GO
ALTER TABLE [dbo].[order_detail]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK__orders__customer__5441852A] FOREIGN KEY([customer_id])
REFERENCES [dbo].[customer] ([customer_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK__orders__customer__5441852A]
GO
