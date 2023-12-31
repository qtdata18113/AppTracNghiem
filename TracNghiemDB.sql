USE [TracNghiemDB]
GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 3/25/2023 12:21:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoi](
	[MaCH] [nchar](10) NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[DapAn1] [nvarchar](max) NULL,
	[DapAn2] [nvarchar](max) NULL,
	[DapAn3] [nvarchar](max) NULL,
	[DapAn4] [nvarchar](max) NULL,
	[HinhAnh] [nchar](200) NULL,
	[DapAnDung] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 3/25/2023 12:21:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaKQ] [nchar](10) NOT NULL,
	[MaTK] [nchar](10) NOT NULL,
	[Diem] [int] NOT NULL,
	[NgayThi] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 3/25/2023 12:21:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [nchar](10) NOT NULL,
	[TenDN] [nchar](20) NOT NULL,
	[MatKhau] [nchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[VaiTro] [tinyint] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH1       ', N'Phần của đường bộ được sử dụng cho các phương tiện giao thông qua lại là gì?', N'Phần mặt đường và lề đường.', N'Phần đường xe chạy.', N'Phần đường xe cơ giới.', N'', NULL, N'2         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH2       ', N'Biển báo hiệu có dạng hình tròn, viền đỏ, nền trắng, trên nền có hình vẽ hoặc chữ số, chữ viết màu đen là loại biển gì dưới đây?', N'Biển báo nguy hiểm.', N'Biển báo cấm.', N'Biển báo hiệu lệnh.', N'Biển báo chỉ dẫn.', N'bien-1.png                                                                                                                                                                                              ', N'2         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH3       ', N'Biển báo hiệu có dạng tam giác đều, viền đỏ, nền màu vàng, trên có hình vẽ màu đen là loại biển gì dưới đây?', N'Biển báo nguy hiểm.', N'Biển báo cấm.', N'Biển báo hiệu lệnh.', N'Biển báo chỉ dẫn', N'bien-2.png                                                                                                                                                                                              ', N'1         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH5       ', N'Hành vi vận chuyển đồ vật cồng kềnh bằng xe mô tô, xe gắn máy khi tham gia giao thông có được phép hay không?', N'Không được vận chuyển.', N'Chỉ được vận chuyển khi đã chằng buộc cẩn thận', N'Chỉ được vận chuyển vật cồng kềnh trên xe máy nếu khoảng cách về nhà ngắn hơn 2 km.', N'', NULL, N'1         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH6       ', N'Người đủ 16 tuổi được điều khiển các loại xe nào dưới đây?', N'Xe mô tô 2 bánh có dung tích xi lanh từ 50 cm3 trở lên.', N'Xe gắn máy có dung tích xi lanh dưới 50 cm3.', N'Xe ô tô tải dưới 3,5 tấn; xe chở người đến 9 chỗ ngồi.', N'Tất cả các ý nêu trên.', NULL, N'2         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH7       ', N'Người có giấy phép lái xe mô tô hạng A1 được phép điều khiển loại xe nào dưới đây?', N'Xe mô tô hai bánh có dung tích xi lanh từ 50 cm3 đến dưới 175 cm3.', N'Xe mô tô ba bánh dùng cho người khuyết tật.', N'Cả ý 1 và ý 2.', N'', NULL, N'3         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH8       ', N'Biển báo hiệu hình tròn có nền xanh lam có hình vẽ màu trắng là loại biển gì dưới đây?', N'Biển báo cấm.', N'Biển báo nguy hiểm.', N'Biển báo hiệu lệnh phải thi hành.', N'Biển báo chỉ dẫn.', N'bien-3.png                                                                                                                                                                                              ', N'3         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH9       ', N'“Làn đường” là gì?', N'Là một phần của phần đường xe chạy được chia theo chiều dọc của đường, sử dụng cho xe chạy.', N'Là đường cho xe ô tô chạy, dừng, đỗ an toàn.', N'Là một phần của phần đường xe chạy được chia theo chiều dọc của đường, có bề rộng đủ cho xe chạy an toàn.', N'', NULL, N'3         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH4       ', N'Người ngồi trên xe mô tô hai bánh, xe mô tô ba bánh, xe gắn máy khi tham gia giao thông có được bám, kéo hoặc đẩy các phương tiện khác không?', N'Được phép.', N'Được bám trong trường hợp phương tiện của mình bị hỏng.', N'Được kéo, đẩy trong trường hợp phương tiện khác bị hỏng.', N'Không được phép.', NULL, N'4         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH10      ', N'Khi gặp hiệu lệnh như dưới đây của cảnh sát giao thông thì người tham gia giao thông phải đi như thế nào là đúng quy tắc giao thông?', N'Người tham gia giao thông ở các hướng phải dừng lại.', N'Người tham gia giao thông ở các hướng được đi theo chiều gậy chỉ của cảnh sát giao thông.', N'Người tham gia giao thông ở phía trước và phía sau người điều khiển được đi tất cả các hướng; người tham gia giao thông ở phía bên phải và phía bên trái người điều khiển phải dừng lại.', N'Người tham gia giao thông ở phía trước và phía sau người điều khiển phải dừng lại; người tham gia giao thông ở phía bên phải và phía bên trái người điều khiển được đi tất cả các hướng.', N'bien-5.png                                                                                                                                                                                              ', N'4         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH11      ', N'Bạn đang lái xe trong khu vực đô thi từ 22 giờ đến 5 giờ sáng hôm sau và cần vượt một xe khác, bạn cần báo hiệu như thế nào để đảm bảo an toàn giao thông?', N'Phải báo hiệu bằng đèn hoặc còi.', N'Chỉ được báo hiệu bằng còi.', N'Phải báo hiệu bằng cả còi và đèn.', N'Chỉ báo hiệu bằng đèn.', NULL, N'4         ')
INSERT [dbo].[CauHoi] ([MaCH], [NoiDung], [DapAn1], [DapAn2], [DapAn3], [DapAn4], [HinhAnh], [DapAnDung]) VALUES (N'CH12      ', N'Câu 12', N'a', N'b', N'c', N'd', NULL, N'1         ')
GO
INSERT [dbo].[KetQua] ([MaKQ], [MaTK], [Diem], [NgayThi]) VALUES (N'KQ1       ', N'TK2       ', 5, CAST(N'2023-03-16T00:00:00.000' AS DateTime))
INSERT [dbo].[KetQua] ([MaKQ], [MaTK], [Diem], [NgayThi]) VALUES (N'KQ2       ', N'TK2       ', 4, CAST(N'2023-03-17T00:00:00.000' AS DateTime))
INSERT [dbo].[KetQua] ([MaKQ], [MaTK], [Diem], [NgayThi]) VALUES (N'KQ3       ', N'TK3       ', 5, CAST(N'2023-03-24T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TaiKhoan] ([MaTK], [TenDN], [MatKhau], [HoTen], [VaiTro]) VALUES (N'TK1       ', N'admin               ', N'admin                                             ', N'Admin', 0)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenDN], [MatKhau], [HoTen], [VaiTro]) VALUES (N'TK2       ', N'nguyenvana          ', N'123456                                            ', N'Nguyễn Văn A', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenDN], [MatKhau], [HoTen], [VaiTro]) VALUES (N'TK3       ', N'qtdat               ', N'12345678                                          ', N'Quảng Tấn Đạt', 1)
GO
