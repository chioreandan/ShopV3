USE [ShopV3]
GO

------ USERS SEED


INSERT INTO Users(NumePrenume,Email,Telefon,Adresa,Parola,Nickname)
Values('Pop Alexandru','pop.alexandru@yahoo.com','0745034551','Observator 10','Pop123','Alex'),
('Moldovan Mihai','moldovanmihai@yahoo.com','0746223115','Observator 3','moldo34','MoldovanM'),
('Popescu Ion','ion_popescu@yahoo.com','0745075241','Meteor 10','Popion','Popescu'),
('Rusu Maria','maria.rusu@yahoo.com','0264977853','Dorobanti 30','Maria1','MariaR'),
('Muntean Alina','alinam@yahoo.com','0231557993','Dorobanti 80','Alina20','AlinaM'),
('Neag Andrei','andreineag@yahoo.com','027877655','Pandurilor 100','andrei123','NAndrei'),
('Muresan Bianca','biancam@gmail.com','0745564123','Pandurilor 30','Bianca1','Bianca'),
('Moldovan Raul','raulmoldovan@gmail.com','0234455613','Infratirii 53','Raul123','RaulM'),
('Avram Diana','avram_dianam@gmail.com','0264774112','Infratirii 30','Diana1','ADiana'),
('Manea Vlad','vlad_manea@gmail.com','5467455643','Avram Iancu 64','Manea1','Vlad1'),
('Farcas Florin','florin_farcas@gmail.com','027877655','Avram Iancu 79','Farcas1','FlorinF'),
('Stan George','georgestan@gmail.com','0740550643','Plopilor 230','Stan1','GeorgeS'),
('Chiriac Alexandra','alexandra_chiriac@gmail.com','075678643','Plopilor 33','Alexandra1','AlexandraC'),
('Jurca Costel','jurca_costel@gmail.com','0234552140','Aurel Vlaicu 108','Costel1','CostelJ'),
('Ardelean Paul','paul_ardelean@gmail.com','027877655','Jupiter 15','Paul1','PaulAr'),
('PMC Group Distributie','pmcgroupdistributie@emag.ro','0785224464','Str. Campia Libertatii, Nr.27, Bl.42, Sector 3,Bucuresti','PMCPass','ForIT'),
('Flanco Group','contact@flanco.com','0261400401','Sos. Bucuresti Nord Nr.15-23, Voluntari','Flanco','Flanco'),
('Altex Romania','contact@altexro.com','0213199939','Sos. Bucuresti Nord Nr.10, Voluntari','Altex','Altex'),
('Domo Romania','comenzi@domo.ro','0372245334','Str. Iuliu Maniu 7 Corp A parter, Sector 6 Bucuresti ','Domo','Domo'),
('Media Galaxy','contact@altexro.com','0213199939','Sos. Bucuresti Nord Nr.10, Voluntari','MediaGalaxy','Media Galaxy'),
('eMag Romania','contatct@emag.ro','0212005200','Cladirea Platinia, Calea Dorobantilor 33, Cluj-Napoca','Emag','Emag'),
('Direct Client Services','carturesti@emag.ro','0728828907','Bucuresti, Setor 1, Str. Edgar Quinet, Nr. 9','Carturesti','Carturesti'),
('Auto Scan','autoscan@emag.ro','0722349934','Strada Bucuresti, nr 55B, Cluj Napoca','Autoscan','Autoscan');
----Vanzatori

INSERT INTO Vanzatori(UserId,NumeCompanie, Cont,CUI)
VALUES(18,'Altex','RO35INGB0000977903208992','RO17369785'),
(19,'Domo','RO14INGB0000888815438941','RO39442157'),
(20,'Media Galaxy','RO39INGB0011899905206872','RO17224152'),
(16,'ForIT','RO07INGB0000999905206872','RO17116469'),
(21,'eMag','RO13INGB00009999773206872','RO11266469'),
(17,'Flanco','RO13INGB000099997732448521','RO27698631'),
(22,'Carturesti','RO51BUCU127302372511RO01','RO11648548'),
(23,'Autoscan','RO37BRDE040SV65263450400','RO32189995');


-----Admini

INSERT INTO Admins(UserId)
VALUES(1),
(21);


----De introdus:

----Branduri
INSERT INTO Branduri(NumeBrand)
VALUES('Lenovo'),
('HP'),
('Asus'),
('Dell'),
('Acer'),
('Apple'),
('MSI'),
('Toshiba'),
('Microsoft'),
('Samsung'),
('Huawei'),
('Xiaomi'),('Sony'),('LG'),('Allview'),('Nokia'),('HTC'),('Google'),('Oneplus'),('Intel'),('AMD'),('Kingstone'),
('Gigabyte'),('Sapphire'),('Corsair'),('HyperX'),('Michelin'),('Continental'),('Pirelli'),('Rao'),('Litera'),('Nike'),('Adidas'),('Jack & Jones'),('Puma');



---- Categorii Produse

INSERT INTO CategoriiProduse(NumeCategorie)
VALUES('Laptopuri'),
('Tablete'),
('Telefoane'),
('PC & Periferice'),
('TV, Audio-Video & Foto'),
('Gaming'),
('Haine'),
('Carti'),
('Auto & Moto');

---- Produse


INSERT INTO Produse(VanzatorId,BrandId,CategorieId,NumeProdus,Pret, Stoc, Caracteristici)
VALUES(1,5,1,'Laptop Acer Aspire A515-41G-F2SH','2199.99',13,'MD Quad-Core FX 7th Gen 9800P 2.70 GHz, 15.6", Full HD, 8GB, 256GB SSD, AMD Radeon™ RX 540 2GB, Linux, Black'),
(1,1,1,'Laptop Gaming Lenovo Legion Y520-15IKBN','2899.99',10,'Intel® Core™ i5-7300HQ 2.50 GHz, Kaby Lake, 15.6", Full HD, IPS, 4GB, 1TB, nVIDIA GeForce GTX 1050 2GB, Free DOS, Black'),
(1,2,1,'Laptop HP 250 G6','1249.99',20,'Intel® Celeron N3350 pana la 2.48 GHz, 15.6" HD, 4GB, 500GB, Intel HD Graphics, Windows 10, Dark Ash Silver'),
(2,4,1,'Laptop Dell Inspiron 3552','999.99',15,'Intel® Celeron® N3060 pana la 2.48 GHz, 15.6", 4GB, 500GB, DVD-RW, Intel® HD Graphics, Ubuntu Linux 14.04, Black'),
(2,6,2,'Apple iPad mini 4','2249.90',8,'Wi-Fi, 128GB, Space Grey'),
(3,10,2,'Tableta Samsung Tab A T585 (2016)','1199.99',9,'Octa-Core 1.6 GHz, 10.1", 2GB RAM, 32GB, 4G, Black'),
(3,11,2,'Tableta Huawei MediaPad M2','1199.99',7,'10.1", Octa Core 2.0 GHz, 2GB RAM, 16GB, 4G, Silver'),
(4,1,2,'Tableta Lenovo Tab 3 TB3-710F','319.99',15,'7'', Quad-Core 1.3 GHz, 1GB, 16GB, Black'),
(4,12,3,'Telefon mobil Xiaomi Redmi 5 Plus','899.99',7,'Dual SIM, 64GB, 4G, Black'),
(5,13,3,'Telefon mobil Sony XZ Premium','2499.99',5,'64GB, 4G, Deepsea Black'),
(5,14,3,'Telefon mobil LG V30','2799.99',8,'64GB, 4G, Cloud Silver'),
(6,15,3,'Telefon mobil Allview X3 Soul Style','749.99',10,'Dual SIM, 32GB, 4G, Gold'),
(6,20,4,'Sistem PC Gaming Hurricane','2445.00',5,'Intel Core i5-3470 3.20 GHz, 16GB DDR3, 240GB SSD, GeForce GT 1030 2G OC 2GB, DVD-RW'),
(6,3,4,'Sistem Desktop PC ASUS K20CD-K-RO004D','1499.99',7,'Intel® Core™ i3-7100 3.90 GHz, Kaby Lake, 4GB, 128GB SSD, DVD-RW, Intel HD Graphics, Free DOS, Black, Mouse + Tastatura'),
(1,25,4,'Casti cu microfon Corsair Gaming Void','449.99',8,'Wireless, iluminare RGB, 7.1 Dolby, culoare galbena'),
(2,22,4,'Solid State Drive (SSD) Kingston A400','149.99',15,'120GB, 2.5", SATA III'),
(3,8,5,'Televizor LED Smart Toshiba','849.99',6,'81 cm, 32W3663DG, HD'),
(4,14,5,'Televizor LED Smart LG','1699.99',5,'108 cm, 43UJ620V, 4K Ultra HD'),
(5,13,5,'Televizor Smart LED Sony Bravia','2649.99',5,'123.2 cm, 49XE7005, 4K Ultra HD'),
(6,10,5,'Televizor LED Curbat Smart Samsung','2799.99',4,'138 cm, 55MU6202, 4K Ultra HD'),
(7,13,6,'PlayStation 4 Slim 500GB Black','1178.10',10,'Sony PS4'),
(3,9,6,'Consola Microsoft Xbox One X','2099.99',7,'1TB, Negru'),
(4,13,6,'Joystick Sony PS4 ','220.00',15,'Dualshock 4 , WIRELESS Controler'),
(2,26,6,'Tastatura mecanica gaming HyperX Alloy FPS','395.00',10,'Cherry MX Red'),
(5,32,7,'Nike, Tricou athletic cut cu imprimeu logo','69.99',20,'Rosu S/M/L/XL/2XL'),
(5,35,7,'Puma, Pantaloni sport cu talie elastica si aplicatie logo Style','99.99',10,'Negru, S'),
(5,34,7,'Jack&Jones, Tricou tall slim fit bej melange Jack 12103171-ALUMINUM','69.99',15,'Bej, S/M/L'),
(5,33,7,'Sapca Adidas 6pcap Ltwgt Emb BK0794','70.00',10,'Unisex Alb Marime universala'),
(7,30,8,'Hotul de carti - Markus Zusak','25.00',20,''),
(7,30,8,'Codul lui Da Vinci - Dan Brown','17.99',20,''),
(7,31,8,'Testamentul lui Abraham - Igor Bergler','38.99',15,''),
(7,31,8,'SILVER BAY - Jojo Moyes','27.99',18,''),
(8,29,9,'Anvelopa Vara Pirelli P7 ','339.99',40,'205/55 R16 91V'),
(8,29,9,'Anvelopa vara Pirelli Cinturato P1 Verde ','248.99',40,'195/65R15 91H'),
(8,27,9,'Set 4 anvelope vara Michelin Cross Climate XL','1862.99',8,'Cu marcaje de iarna, 205/55 R16 94V'),
(8,28,9,'Set 4 Anvelope Vara Continental ContiPremiumContact 5 ','1159.99',5,'195 65 R15 91H');


