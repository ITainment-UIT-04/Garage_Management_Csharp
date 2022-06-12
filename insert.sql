﻿use QUANLIGARA
go
insert into HIEUXE(HieuXe) values
('Innova'),
('Honda'),
('Hyundai'),
('Lamborghini'),
('Toyota'),
('Ferrari'),
('Wolkswagen')

INSERT INTO PHUTUNG(MaVTPT, TenVTPT, SoLuongTon, DonGia) VALUES
('PT200',N'Búp sen thắng sau','79','700000'),
('PT201',N'Ắc quy','73','1970000'),
('PT202',N'Ba đờ sốc trước','96','1170000'),
('PT203',N'Lọc nhớt động cơ','66','120000'),
('PT204',N'Lọc nhớt nhiên liệu','84','170000'),
('PT205',N'Bộ giảm chấn','50','3750000'),
('PT206',N'Bạc đạn bánh xe','56','160000'),
('PT207',N'Bạc đạn trong trục','65','130000'),
('PT208',N'Gương chiếu hậu','89','320000'),
('PT209',N'Đèn pha trước','54','1320000'),
('PT210',N'Đèn hậu','78','480000'),
('PT211',N'Dây đai trợ lực lái','58','350000'),
('PT212',N'Bộ bạc đạn ly hợp','76','220000'),
('PT213',N'Đĩa bộ ly hợp','80','760000'),
('PT214',N'Bạc thanh truyền dưới','99','370000'),
('PT215',N'Kính chắn gió','61','1200000'),
('PT216',N'Kính chắn gió (loại bảo mật)','90','1600000'),
('PT217',N'Bản lề nắp thùng','77','85000'),
('PT218',N'Bầu lọc gió','88','1200000'),
('PT219',N'Bầu phanh','57','320000'),
('PT220',N'Bệ gắn lò xo','83','150000'),
('PT221',N'Piston','74','1100000'),
('PT222',N'Bạc séc măng','99','250000'),
('PT223',N'Bộ gioăng đại tu động cơ','88','90000'),
('PT224',N'Gioăng nắp quy lát','55','200000'),
('PT225',N'Két giải nhiệt nhớt','54','1200000'),
('PT226',N'Két làm mát gió nạp','83','1600000'),
('PT227',N'Nắp đậy lọc gió','100','120000'),
('PT228',N'Ống dẫn gió nạp từ lọc gió','94','160000'),
('PT229',N'Ống dẫn gió vào turbo','82','160000'),
('PT230',N'Cáp bàn đạp ga','62','80000'),
('PT231',N'Cáp điều khiển mô tơ cắt nhiên liệu','63','110000'),
('PT232',N'Bếc phun nhiên liệu','63','260000'),
('PT233',N'Bơm tay','50','220000'),
('PT234',N'Bugi xông','98','340000'),
('PT235',N'Nắp đậy trước thân máy','78','570000'),
('PT236',N'Phốt đầu cốt máy','52','160000'),
('PT237',N'Phốt đuôi cốt máy','78','150000'),
('PT238',N'Vòng răng bánh đà','60','210000'),
('PT239',N'Các-te nhớt','68','260000'),
('PT240',N'Gioăng cao su có nắp đậy','88','160000'),
('PT241',N'Cổ xupap nạp, thải','74','180000'),
('PT242',N'Xupap nạp, xupap thải','64','360000'),
('PT243',N'Bơm nước làm mát','90','260000'),
('PT244',N'Cánh quạt làm mát','61','320000'),
('PT245',N'Dây đai dẫn động bơm nước + máy phát','51','870000'),
('PT246',N'Két nước giải nhiệt','75','1600000'),
('PT247',N'Họng gió két nước','91','450000'),
('PT248',N'Van điều tiết nước giải nhiệt','100','320000'),
('PT249',N'Ống cao su dẫn nước vào','50','120000'),
('PT250',N'Ống cao su dẫn nước ra','97','120000'),
('PT251',N'Nắp két nước giải nhiệt','57','160000'),
('PT252',N'Bơm nhốt','84','275000'),
('PT253',N'Đề máy','90','470000'),
('PT254',N'Máy phát điện','82','1900000'),
('PT255',N'Đi-ốt sạc','72','680000'),
('PT256',N'Bơm chân không','90','460000'),
('PT257',N'Cảm biến nhiệt độ nước làm mát lên đồng hồ','65','240000')
insert into TIENCONG(MaTienCong, NoiDung, TienCong) values
('TC0',N'Công thay dầu máy xe ô tô','50000'),
('TC1',N'Công thay lọc dầu xe ô tô','50000'),
('TC2',N'Công thay dầu máy, lọc dầu xe ô tô','80000'),
('TC3',N'Thay lọc xăng xe ô tô','100000'),
('TC4',N'Thay lọc xăng thả thùng','200000'),
('TC5',N'Thay lọc nhiên liệu xe ô tô','50000'),
('TC6',N'Thay dầu hộp số MT','100000'),
('TC7',N'Thay dầu hộp số AT (trường hợp đặc biệt tăng không quá 50%)','200000'),
('TC8',N'Thay chế hòa khí, chỉnh máy','350000'),
('TC9',N'Thay lọc gió xe ô tô','20000'),
('TC10',N'Thay bugi xe ô tô','100000'),
('TC11',N'Công bảo dưỡng mỗi 10.000đ km xe Sedan (không bao gồm vật tư)','200000'),
('TC12',N'Công bảo dưỡng mỗi 10.000đ km xe SUV (không bao gồm vật tư)','250000'),
('TC13',N'Công bảo dưỡng mỗi 20.000km xe Sedan (không bao gồm vật tư)','300000'),
('TC14',N'Công bảo dưỡng mỗi 20.000km xe SUV (không bao gồm vật tư)','450000'),
('TC15',N'Bảo dưỡng chế hoà khí, chỉnh máy (bao gồm vật liệu bảo dưỡng)','350000'),
('TC16',N'Bảo dưỡng cụm bướm ga, chỉnh máy (bao gồm vật liệu bảo dưỡng)','300000'),
('TC17',N'Bảo dưỡng cụm bướm ga, thông súc tu bô, chỉnh máy (bao gồm vật liệu bảo dưỡng)','500000'),
('TC18',N'Kiểm tra, vệ sinh bugi (trường hợp tháo bugi phức tạp thêm công 100%)','50000'),
('TC19',N'Bảo dưỡng Delco xe ô tô','100000'),
('TC20',N'Bảo dưỡng máy phát điện xe ô tô','200000'),
('TC21',N'Bảo dưỡng máy đề xe ô tô','200000'),
('TC22',N'Thay nước mát xe ô tô','20000'),
('TC23',N'Thông súc két nước (không tháo) (bao gồm dung dịch làm sạch)','300000'),
('TC24',N'Thông súc két nước (tháo két nước ra ngoài)','350000'),
('TC25',N'Tháo hàn két nước, thông súc','450000'),
('TC26',N'Tháo lắp kiểm tra kim phun, bơm cao áp (loại bơm không cân)','400000'),
('TC27',N'Tháo lắp cân kim phun','600000'),
('TC28',N'Cân bơm cao áp xe ô tô','500000'),
('TC29',N'Thông súc bình xăng hoặc thùng dầu xe ô tô','350000'),
('TC30',N'Tăng chỉnh dây curoa ngoài /1 dây','50000'),
('TC31',N'Tăng chỉnh dây curoa ngoài (3 dây)','100000'),
('TC32',N'Thay phớt chân bugi (bộ) bao gồm keo gioăng – xe 4 máy chạy chế hoà khí','200000'),
('TC33',N'Thay phớt chân bugi (bộ) bao gồm keo gioăng – xe 4 máy phun xăng','300000'),
('TC34',N'Đối với máy V6, công dịch vụ tăng không quá 50%','200000'),
('TC35',N'Thay gioăng nắp supap bao gồm keo gioăng (4 máy)','200000'),
('TC36',N'Thay gioăng nắp supap bao gồm keo gioăng (máy V), thay cả 2 bên tăng thêm 80%','250000'),
('TC37',N'Kiểm tra thay dây cao áp','100000'),
('TC38',N'Bảo dưỡng láp trong (1 bên)','150000'),
('TC39',N'Bảo dưỡng phanh trước hoặc sau','150000'),
('TC40',N'Bảo dưỡng moay ơ trước / 1 bánh (xe Sedan)','150000'),
('TC41',N'Bảo dưỡng moay ơ trước / 1 bánh (xe SUV)','200000'),
('TC42',N'Bảo dưỡng phanh moay ơ 4 bánh (xe Sedan)','500000'),
('TC43',N'Bảo dưỡng phanh moay ơ 4 bánh (xe SUV)','600000'),
('TC44',N'Chỉnh độ chụm, góc đặt bánh xe','150000'),
('TC45',N'Cân bằng động 1 bánh xe (bao gồm cả kẹp chì)','100000'),
('TC46',N'Tháo lắp bảo dưỡng hệ thống trục vô lăng lái, căn chỉnh lái','600000'),
('TC47',N'Tháo lắp hộp số thay bánh răng','1500000'),
('TC48',N'Tháo lắp thay lá côn hộp số tự động','3000000'),
('TC49',N'Thay hộp số tự động','800000'),
('TC50',N'Thay bi hộp số hoặc ruột hộp số','2000000'),
('TC51',N'Thay láp ngoài / 1 bên','200000'),
('TC52',N'Thay láp trong / 1 bên','200000'),
('TC53',N'Thay láp cả cây','200000'),
('TC54',N'Thay phớt láp','100000'),
('TC55',N'Thay bi moay ơ trước hoặc cụm bi /1 bên','150000'),
('TC56',N'Thay bi moay ơ sau hoặc cụm bi /1 bên','150000'),
('TC57',N'Thay má phanh trước','150000'),
('TC58',N'Thay cuppen phanh trước, xả e','200000'),
('TC59',N'Thay cupen phanh sau, xả e','200000'),
('TC60',N'Thay dầu phanh (tháo các bộ phận vệ sinh, xả e, KT)','250000'),
('TC61',N'Thay dầu phanh không tháo các bộ phận, xả e','150000'),
('TC62',N'Thay tổng phanh, xả e','150000'),
('TC63',N'Thay cụm ABS, test xoá lỗi','500000'),
('TC64',N'Thay ruột tổng phanh, xả e','200000'),
('TC65',N'Thay tuy ô phanh, xả e','100000'),
('TC66',N'Thay ruột tổng côn, xả e','100000'),
('TC67',N'Thay trượt côn dưới hoặc ruột, xả e','100000'),
('TC68',N'Thay rô tuyn lái ngoài hoặc cao su chụp bụi thước lái, chỉnh lái','150000'),
('TC69',N'Thay rô tuyn lái trong, chỉnh lái','150000'),
('TC70',N'Thay bộ lái (lái trong + lái ngoài), chỉnh lái','300000'),
('TC71',N'Thay rô tuyn cân bằng trước sau','100000'),
('TC72',N'Thay cao su cân bằng trước, sau','50000'),
('TC73',N'Thay rô tuyn đứng trên hoặc dưới','100000'),
('TC74',N'Thay bộ rotuyn đứng (4 quả)','300000'),
('TC75',N'Thay càng A hoặc cao su càng A (TH phức tạp công tăng 50%)','200000'),
('TC76',N'Thay càng A dưới hoặc cao su (TH phức tạp công tăng 30%)','150000'),
('TC77',N'Thay giá bắt moay ơ trước (sau)','150000'),
('TC78',N'Kiểm tra thay cảm biến ABS','150000'),
('TC79',N'Thay bát bèo trước, sau hoặc bi bát bèo (TH phức tạp công tăng 50%)','150000'),
('TC80',N'Thay giảm sóc trước (sau)','100000'),
('TC81',N'Thay lò xo giảm sóc trước (sau)','150000'),
('TC82',N'Thay phớt thước lái + căn chỉnh','400000'),
('TC83',N'Thay Bộ phớt bót lái + căn chỉnh','300000'),
('TC84',N'Thay phớt hoặc bạc, hoặc BD thước lái cơ','350000'),
('TC85',N'Thay thước lái cơ, căn chỉnh góc lái','250000'),
('TC86',N'Thay thước lái trợ lực, căn chỉnh góc lái','300000'),
('TC87',N'Thay bơm trợ lực (TH phức tạp công tăng 50%)','150000'),
('TC88',N'Tháo lắp thay phớt bơm trợ lực','200000'),
('TC89',N'Thay khớp các đăng lái (TH phức tạp công tăng 50%)','150000'),
('TC90',N'Thay thanh chuyển hướng lái + căn chỉnh góc lái','200000'),
('TC91',N'Thay thanh giằng dọc sau hoặc ngang sau','100000'),
('TC92',N'Thay cao su giằng dọc sau','100000'),
('TC93',N'Thay dây công tơ mét hoặc cảm biến CTM','150000'),
('TC94',N'Thay dây côn','150000'),
('TC95',N'Thay lốp hoặc la zăng (bao gồm cân bằng động)','80000'),
('TC96',N'BD máy phát (bao gồm xăng dầu rửa, mỡ…)','200000'),
('TC97',N'BD máy đề (bao gồm xăng dầu rửa, mỡ…)','200000'),
('TC98',N'BD, VS mô tơ quạt dàn lạnh','50000'),
('TC99',N'BD lốc lạnh + nạp ga + dầu lốc (đã bao gồm ga và dầu)','750000'),
('TC100',N'BD, VÀ hệ thống điều hòa + nạp ga + dầu lốc (1 giàn)','1000000'),
('TC101',N'BD, VÀ hệ thống điều hòa + nạp ga + dầu lốc (2 giàn)','1300000'),
('TC102',N'BD, VÀ hệ thống điều hòa + nạp ga + dầu lốc (1 giàn) (TH phải tháo táp lô)','1500000'),
('TC103',N'BD mô tơ lên xuống kính cửa','50000'),
('TC104',N'Thay ắc quy','50000'),
('TC105',N'Thay còi','50000'),
('TC106',N'Thay còi + lắp chuyển đổi 02 loại còi','150000'),
('TC107',N'Lắp bộ điều khiển chốt cửa (bao gồm rơ le)','250000'),
('TC108',N'Thay đèn pha hoặc phải tháo đèn pha để thay bóng đèn','100000'),
('TC109',N'Thay đèn xi nhan','50000'),
('TC110',N'Thay đèn padershock trước','50000'),
('TC111',N'Lắp đèn padershock trước (1 bộ bao gồm cả công tắc)','150000'),
('TC112',N'Lắp đầu CD, VCD, DVD (TH phức tạp phải khảo sát và thỏa thuận với khách)','300000'),
('TC113',N'Thay loa đài','100000'),
('TC114',N'Thay ăng ten','150000'),
('TC115',N'Thay quạt két nước, quạt giàn nóng hoặc cánh quạt','100000'),
('TC116',N'Thay rơ le ngắt lạnh (lắp rơ le cơ)','150000'),
('TC117',N'Thay máy phát (TH phải tháo lắp nhiều, công tăng 50%)','150000'),
('TC118',N'Thay chổi than, IC máy phát + BD','200000'),
('TC119',N'Thay chổi than máy đề + BD','150000'),
('TC120',N'Thay máy đề','150000'),
('TC121',N'Thay mô tơ lên kính cửa','100000'),
('TC122',N'Thay đồng hồ táp lô hoặc đồng hồ CTM','300000'),
('TC123',N'Thay công tắc lên kính cửa','100000'),
('TC124',N'Thay giàn sưởi','650000'),
('TC125',N'Thay cảm biến báo nhiên liệu','300000'),
('TC126',N'Thay mô tơ trượt ghế','350000'),
('TC127',N'Thay mô tơ gạt mưa','200000'),
('TC128',N'Thay mô tơ bơm nước rửa kính','100000'),
('TC129',N'BD, đổ nước ắc quy (bao gồm cả nước axit)','100000'),
('TC130',N'Láng bàn ép hoặc bánh đà','250000'),
('TC131',N'Láng bàn ép bánh đà','400000'),
('TC132',N'Láng đĩa phanh, tăm bua','200000'),
('TC133',N'Láng bôn từ lốc lạnh (chưa bao gồm công tháo lắp lốc lạnh)','200000'),
('TC134',N'Chế công bi láp','200000'),
('TC135',N'Ép tuy ô điều hòa + hàn (chưa bao gồm vật tư)','200000'),
('TC136',N'Ép tuy ô trợ lực (chưa bao gồm vật tư)','200000'),
('TC137',N'Gia công chế 01 rô tuyn','350000'),
('TC138',N'Mài rà mặt máy (không bao gồm công tháo lắp)','550000'),
('TC139',N'Doa mài xi lanh 04 máy (không bao gồm công đại tu máy)','800000'),
('TC140',N'Doa mài xi lanh 6-8 máy (không bao gồm công đại tu máy)','1000000'),
('TC141',N'Thay xi lanh (đóng nòng) (không bao gồm công đại tu máy)','400000'),
('TC142',N'Mài trục cơ 04 máy','450000'),
('TC143',N'Mài trục cơ 06 máy','700000'),
('TC144',N'Thay vai két nước (chế vai két nước bao gồm thông súc)','800000'),
('TC145',N'Đánh 01 chìa khóa (bao gồm phôi chìa)','300000'),
('TC146',N'Gia công, đánh bóng thanh thước lái + thay phớt (sedan)','2200000'),
('TC147',N'Gia công, đánh bóng thanh thước lái + thay phớt (SUV xe đặc chủng)','3000000'),
('TC148',N'Công thay tay mở cửa ngoài, trong','100000'),
('TC149',N'Công thay nẹp cánh cửa','100000'),
('TC150',N'Công thay ốp phồng','100000'),
('TC151',N'Công thay chắn bùn','50000'),
('TC152',N'Công thay lòng dè','100000'),
('TC153',N'Công thay trần','700000'),
('TC154',N'Công thay mặt gương (phức tạp công tăng 50%)','100000'),
('TC155',N'Công thay ca lăng',' 200000'),
('TC156',N'Công thay chắn bùn gầm máy','100000')

insert into XE(Bienso, Hieuxe, TenChuXe, DiaChi, DienThoai, NgayTiepNhan, TienNo) values
('72F-48539','Innova',N'Lày A Cẩu',N'Quận Bình Thạnh, TP.HCM','982527982','2022-05-05 00:00:00','7800000'),
('88G-91668','Innova',N'Bùi Mạnh Quốc Huy',N'Quận Bình Thạnh, TP.HCM','973776072','2022-05-05 00:00:00','530000'),
('21A-22382','Innova',N'Lê Thị Mai',N'Quận Bình Thạnh, TP.HCM','917749254','2022-05-05 00:00:00','2000000'),
('77H-86543','Innova',N'Trần Kim Ngọc',N'Quận Gò Vấp, TP.HCM','904770053','2022-05-05 00:00:00','1950000'),
('41A-61395','Innova',N'Lai Như Quỳnh',N'Quận 2, TP.HCM','974880788','2022-05-05 00:00:00','1300000'),
('74E-31587','Innova',N'Đặng Ngọc Thanh Loan',N'Quận 2, TP.HCM','983888611','2022-05-05 00:00:00','1050000'),
('27B-81356','Innova',N'Đặng Ngọc Thanh Loan',N'Phường Thắng Tam, TP. Vũng Tàu','984603663','2022-05-05 00:00:00','750000'),
('31L-28260','Innova',N'Phạm Đoàn Minh Hiếu',N'Quận Thủ Đức, TP.HCM','986375176','2022-08-05 00:00:00','700000'),
('76L-27275','Honda',N'Cao Ngọc Phương Trinh',N'Quận Thủ Đức, TP.HCM','986253482','2022-08-05 00:00:00','2200000'),
('83B-83361','Honda',N'Đỗ Thị Thùy Dương',N'Quận Thủ Đức, TP.HCM','944545232','2022-08-05 00:00:00','460000'),
('82F-55255','Honda',N'Nguyễn Thị Phương',N'Quận Thủ Đức, TP.HCM','912644784','2022-08-05 00:00:00','260000')
insert into QUYDINH(SoXeSuaChuaToiDa, TiLeLai) VALUES (100, 1.05)
insert into CHUCVU VALUES(N'Quản lý'), (N'Nhân viên')
insert into NHANVIEN VALUES('Tuan', '123', N'Lâm Minh Tuấn', '098', '@gmail', 'TPHCM', N'Quản lý')

