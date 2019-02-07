using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopApp.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ShopStore>
    {
        protected override void Seed(ShopStore context)
        {
            var Products = new List<Product>
            {
                new Product { Name = "Monitor" },
                new Product { Name = "Keyboard" },
                new Product { Name = "Mouse" },
                new Product { Name = "HDD" },
                new Product { Name = "SSD" },
                new Product { Name = "GPU" },
                new Product { Name = "CPU" },
                new Product { Name = "MotherBoard" },
                new Product { Name = "RAM" },
                new Product { Name = "Cooler" },
                new Product { Name = "Speaker" },
            };

            var Brands = new List<Brand>
            {
                //Monitor
                new Brand { Name = "ASUS" },
                new Brand { Name = "LG" },
                new Brand { Name = "AOC" },
                new Brand { Name = "BENQ" },
                new Brand { Name = "SAMSUNG" },
                new Brand { Name = "ACER" },
                new Brand { Name = "Sony" },
                new Brand { Name = "ViewSonic" },
                new Brand { Name = "Gigabyte" },
                new Brand { Name = "HP" },
                new Brand { Name = "Eizo" },
                new Brand { Name = "PHILIPS" },
                new Brand { Name = "Apple" },
                new Brand { Name = "HANNS G" },
                new Brand { Name = "AOC Agon" },

                //Keyboard
                new Brand { Name = "Kumara" },
                new Brand { Name = "RAZER" },
                new Brand { Name = "LOGITECH" },
                new Brand { Name = "Havit" },
                new Brand { Name = "G.Skill" },
                new Brand { Name = "SteelSeries" },
                new Brand { Name = "EVGA" },
                new Brand { Name = "Roccat" },
                new Brand { Name = "Redragon" },
                new Brand { Name = "Gigabyte" },
                new Brand { Name = "NGS" },
                new Brand { Name = "KLONER" },
                new Brand { Name = "Gigabyte" },


                new Brand { Name = "Creative Sound" },

                //Mouse
                new Brand { Name = "Roccat" },
                new Brand { Name = "CoolerMaster" },
                new Brand { Name = "Corsair" },
                new Brand { Name = "HyperX" },
                new Brand { Name = "NVIDIA" },
                new Brand { Name = "MSI" },
                new Brand { Name = "Mars Gaming" },




                //HDD
                new Brand { Name = "Seagate" },
                new Brand { Name = "Western Digital" },
                //SSD
                new Brand { Name = "INTENSO" },
                new Brand { Name = "CRUCIAL" },
                //CPU
                new Brand { Name = "INTEL" },
                //MB
                new Brand { Name = "Asrock" },
                new Brand { Name = "EVGA" },
                new Brand { Name = "Gigabyte" },
                //RAM
                new Brand { Name = "Crucial" },
                //cooler
                new Brand { Name = "Cooler Master" },
                new Brand { Name = "DeepCool" },
                new Brand { Name = "Coolink" },
                new Brand { Name = "Airen" },
                new Brand { Name = "NZXT" },
                //audio
                new Brand { Name = "Creative Sound Blaster" },
                new Brand { Name = "Startech" },
                new Brand { Name = "Kingston" },
                new Brand { Name = "KINGSTON" },
            

            };

            new List<Type>
            {
                new Type { Title = "RTX 2080", Product = Products.Single(g => g.Name == "GPU"), Price = 16200.020M, Brand = Brands.Single(a => a.Name == "NVIDIA"), TypeArtUrl = "/Content/Images/RTX 2080.jpg" },
new Type { Title = "GTX 1080 TI STRIX", Product = Products.Single(g => g.Name == "GPU"), Price = 9500.020M, Brand = Brands.Single(a => a.Name == "NVIDIA"), TypeArtUrl = "/Content/Images/GTX 1080 TI STRIX.jpg" },
new Type { Title = "GTX 1070", Product = Products.Single(g => g.Name == "GPU"), Price = 7000.080M,  Brand = Brands.Single(a => a.Name == "NVIDIA"), TypeArtUrl = "/Content/Images/GTX 1070.jpg" },
new Type { Title = "GTX 1060", Product = Products.Single(g => g.Name == "GPU"), Price = 5200.096M, Brand = Brands.Single(a => a.Name == "MSI"), TypeArtUrl = "/Content/Images/GTX 1060.jpg" },
new Type { Title = "GTX 1050 TI", Product = Products.Single(g => g.Name == "GPU"), Price = 4800.050M, Brand = Brands.Single(a => a.Name == "NVIDIA"), TypeArtUrl = "/Content/Images/GTX 1050 TI.jpg" },
new Type { Title = "GTX 1050", Product = Products.Single(g => g.Name == "GPU"), Price = 3000.010M, Brand = Brands.Single(a => a.Name == "MSI"), TypeArtUrl = "/Content/Images/GTX 1050.jpg" },
new Type { Title = "GTX 980", Product = Products.Single(g => g.Name == "GPU"), Price = 2400.099M, Brand = Brands.Single(a => a.Name == "MSI"), TypeArtUrl = "/Content/Images/GTX 980.jpg" },
new Type { Title = "GTX 960", Product = Products.Single(g => g.Name == "GPU"), Price = 2200.099M, Brand = Brands.Single(a => a.Name == "NVIDIA"), TypeArtUrl = "/Content/Images/GTX 960.jpg" },
new Type { Title = "GTX 880", Product = Products.Single(g => g.Name == "GPU"), Price = 1700.099M, Brand = Brands.Single(a => a.Name == "NVIDIA"), TypeArtUrl = "/Content/Images/GTX 880.jpg" },
new Type { Title = "GTX 970", Product = Products.Single(g => g.Name == "GPU"), Price = 2300.099M, Brand = Brands.Single(a => a.Name == "NVIDIA"), TypeArtUrl = "/Content/Images/GTX 970.jpg" },











new Type { Title = "SAMSUNG C32H711Q 32", Product = Products.Single(g => g.Name == "Monitor"), Price = 6450.099M, Brand = Brands.Single(a => a.Name == "SAMSUNG"), TypeArtUrl = "/Content/Images/SAMSUNG C32H711Q 32.jpg" },
new Type { Title = "ASUS VS278H 27", Product = Products.Single(g => g.Name == "Monitor"), Price = 2770.099M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/ASUS VS278H 27.jpg" },
new Type { Title = "BENQ GL2760H 27", Product = Products.Single(g => g.Name == "Monitor"), Price = 2750.099M, Brand = Brands.Single(a => a.Name == "BENQ"), TypeArtUrl = "/Content/Images/BENQ GL2760H 27.jpg" },
new Type { Title = "HANNS G HE196APB 18", Product = Products.Single(g => g.Name == "Monitor"), Price = 1280.099M, Brand = Brands.Single(a => a.Name == "HANNS G"), TypeArtUrl = "/Content/Images/HANNS G HE196APB 18 .jpg" },
new Type { Title = "ACER V206HQLAB 19.5", Product = Products.Single(g => g.Name == "Monitor"), Price = 1330.099M, Brand = Brands.Single(a => a.Name == "ACER"), TypeArtUrl = "/Content/Images/ACER V206HQLAB 19.5.jpg" },
new Type { Title = "PHILIPS 243V5LHAB 24", Product = Products.Single(g => g.Name == "Monitor"), Price = 1980.099M, Brand = Brands.Single(a => a.Name == "PHILIPS"), TypeArtUrl = "/Content/Images/PHILIPS 243V5LHAB 24.jpg" },
new Type { Title = "ViewSonic VX2458-C-mhd 24 144Hz", Product = Products.Single(g => g.Name == "Monitor"), Price = 3450.099M, Brand = Brands.Single(a => a.Name == "ViewSonic"), TypeArtUrl = "/Content/Images/ViewSonic VX2458-C-mhd 24 144Hz.jpg" },
new Type { Title = "Samsung QLED HDR 32 144Hz", Product = Products.Single(g => g.Name == "Monitor"), Price = 7990.099M, Brand = Brands.Single(a => a.Name == "SAMSUNG"), TypeArtUrl = "/Content/Images/SAMSUNG QLED HDR 32 144Hz.jpg" },
new Type { Title = "Asus MG279Q 27 144Hz", Product = Products.Single(g => g.Name == "Monitor"), Price = 8550.040M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/ASUS MG279Q 27 144Hz.jpg" },
new Type { Title = "AOC Agon AG271QX 27 144Hz", Product = Products.Single(g => g.Name == "Monitor"), Price = 6860.099M, Brand = Brands.Single(a => a.Name == "AOC Agon"), TypeArtUrl = "/Content/Images/AOC Agon AG271QX 27 144Hz.jpg" },






new Type { Title = "NGS TV Warrior", Product = Products.Single(g => g.Name == "Keyboard"), Price = 370.099M, Brand = Brands.Single(a => a.Name == "NGS"), TypeArtUrl = "/Content/Images/NGS TV Warrior.jpg" },
new Type { Title = "Kloner KTB28 Bluetooh Touchpad", Product = Products.Single(g => g.Name == "Keyboard"), Price = 390.099M, Brand = Brands.Single(a => a.Name == "KLONER"), TypeArtUrl = "/Content/Images/Kloner KTB28 Bluetooh Touchpad.jpg" },
new Type { Title = "Razer Ornata Chroma RGB", Product = Products.Single(g => g.Name == "Keyboard"), Price = 1500.099M, Brand = Brands.Single(a => a.Name == "RAZER"), TypeArtUrl = "/Content/Images/Razer Ornata Chroma RGB.jpg" },
new Type { Title = "Asus Cerberus Arctic Gaming Keyboard LED", Product = Products.Single(g => g.Name == "Keyboard"), Price = 900.099M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus Cerberus Arctic Gaming Keyboard LED.jpg" },
new Type { Title = "Logitech Sans fil Touch Keyboard K400 Plus ", Product = Products.Single(g => g.Name == "Keyboard"), Price = 750.099M, Brand = Brands.Single(a => a.Name == "LOGITECH"), TypeArtUrl = "/Content/Images/Logitech Sans fil Touch Keyboard K400 Plus.jpg" },
new Type { Title = "Mars Gaming MK3 Retroilluminé", Product = Products.Single(g => g.Name == "Keyboard"), Price = 780.099M, Brand = Brands.Single(a => a.Name == "NGS"), TypeArtUrl = "/Content/Images/Mars Gaming MK3 Retroilluminé.jpg" },






new Type { Title = "Logitech M560 Sans fil", Product = Products.Single(g => g.Name == "Mouse"), Price = 720.039M, Brand = Brands.Single(a => a.Name == "LOGITECH"), TypeArtUrl = "/Content/Images/Logitech M560 Sans fil.jpg" },
new Type { Title = "Asus Cerberus 2500 DPI USB Gaming", Product = Products.Single(g => g.Name == "Mouse"), Price = 460.039M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus Cerberus 2500 DPI USB Gaming.jpg" },
new Type { Title = "NGS HAZE WHITE 2.4GHz 800-1600 DPI", Product = Products.Single(g => g.Name == "Mouse"), Price = 180.039M, Brand = Brands.Single(a => a.Name == "NGS"), TypeArtUrl = "/Content/Images/NGS HAZE WHITE 2.4GHz 800-1600 DPI.jpg" },
new Type { Title = "Creative Sound BlasterX Siege M04 Gaming 12000 DPI", Product = Products.Single(g => g.Name == "Mouse"), Price = 910.020M, Brand = Brands.Single(a => a.Name == "Creative Sound"), TypeArtUrl = "/Content/Images/Creative Sound BlasterX Siege M04 Gaming 12000 DPI.jpg" },
new Type { Title = "Asus ROG Sica 5000DPI", Product = Products.Single(g => g.Name == "Mouse"), Price = 720.039M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus ROG Sica 5000DPI.jpg" },
new Type { Title = "Mars Gaming MM216 5000 DPI", Product = Products.Single(g => g.Name == "Mouse"), Price = 720.039M, Brand = Brands.Single(a => a.Name == "Mars Gaming"), TypeArtUrl = "/Content/Images/Mars Gaming MM216 5000 DPI.jpg" },



















new Type { Title = "Seagate BarraCuda Compute HDD 2TB 3.5 SATA3", Product = Products.Single(g => g.Name == "HDD"), Price = 1000.020M, Brand = Brands.Single(a => a.Name == "Seagate"), TypeArtUrl = "/Content/Images/Seagate BarraCuda Compute HDD 2TB 3.5 SATA3.jpg" },
new Type { Title = "Western Digital Blue 4TB 3.5", Product = Products.Single(g => g.Name == "HDD"), Price = 1600.020M, Brand = Brands.Single(a => a.Name == "Western Digital"), TypeArtUrl = "/Content/Images/Western Digital Blue 4TB 3.5.jpg" },
new Type { Title = "Western Digital Retail 6TB 3.5", Product = Products.Single(g => g.Name == "HDD"), Price = 4200.020M, Brand = Brands.Single(a => a.Name == "Western Digital"), TypeArtUrl = "/Content/Images/Western Digital Retail 6TB 3.5.jpg" },
new Type { Title = "Seagate BarraCuda Pro HDD 8TB 3.5", Product = Products.Single(g => g.Name == "HDD"), Price = 4360.020M, Brand = Brands.Single(a => a.Name == "Seagate"), TypeArtUrl = "/Content/Images/Seagate BarraCuda Pro HDD 8TB 3.5.jpg" },
new Type { Title = "Seagate Archive HDD 3TB", Product = Products.Single(g => g.Name == "HDD"), Price = 1640.010M, Brand = Brands.Single(a => a.Name == "Seagate"), TypeArtUrl = "/Content/Images/Seagate Archive HDD 3TB.jpg" },



new Type { Title = "Samsung 850 EVO M.2 250GB", Product = Products.Single(g => g.Name == "SSD"), Price = 1690.010M, Brand = Brands.Single(a => a.Name == "SAMSUNG"), TypeArtUrl = "/Content/Images/Samsung 850 EVO M.2 250GB.jpg" },
new Type { Title = "Western Digital Blue 3D Nand 250GB", Product = Products.Single(g => g.Name == "SSD"), Price = 1000.010M, Brand = Brands.Single(a => a.Name == "Western Digital"), TypeArtUrl = "/Content/Images/Western Digital Blue 3D Nand 250GB.jpg" },
new Type { Title = "Samsung 970 EVO 500GB NVMe", Product = Products.Single(g => g.Name == "SSD"), Price = 2130.010M, Brand = Brands.Single(a => a.Name == "SAMSUNG"), TypeArtUrl = "/Content/Images/Samsung 970 EVO 500GB NVMe.jpg" },
new Type { Title = "Intenso Top SSD M.2 240GB", Product = Products.Single(g => g.Name == "SSD"), Price = 890.010M, Brand = Brands.Single(a => a.Name == "INTENSO"), TypeArtUrl = "/Content/Images/Intenso Top SSD M.2 240GB.jpg" },
new Type { Title = "Crucial MX500 500GB 2.5- Disque SSD", Product = Products.Single(g => g.Name == "SSD"), Price = 1490.010M, Brand = Brands.Single(a => a.Name == "CRUCIAL"), TypeArtUrl = "/Content/Images/Crucial MX500 500GB 2.5- Disque SSD.jpg" },







new Type { Title = "Intel Core i7 7700K 4.2 GHz Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 5180.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Core i7 7700K 4.2 GHz Socket 1151.jpg" },
new Type { Title = "Intel Core i3 8300 3.7 GHz Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 2430.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Core i3 8300 3.7 GHz Socket 1151.jpg" },
new Type { Title = "Intel Core i7 8700 4.6 Ghz Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 5840.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Core i7 8700 4.6 Ghz Socket 1151.jpg" },
new Type { Title = "Intel Core i7 8700K Medium OC 4.8Ghz Delid Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 6920.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Core i7 8700K Medium OC 4.8Ghz Delid Socket 1151.jpg" },
new Type { Title = "Intel Core i7 8700K Ultra OC 5.1Ghz Delid Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 7590.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Core i7 8700K Ultra OC 5.1Ghz Delid Socket 1151.jpg" },
new Type { Title = "Intel Core i7 6700K 4.0 GHz Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 4540.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Core i7 6700K 4.0 GHz Socket 1151.jpg" },
new Type { Title = "Intel Core i5 8600K Extreme OC 4.9Ghz Delid Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 5170.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Core i5 8600K Extreme OC 4.9Ghz Delid Socket 1151.jpg" },
new Type { Title = "Intel Core i5 8500 4.10 GHz Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 4050.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Core i5 8500 4.10 GHz Socket 1151.jpg" },
new Type { Title = "Intel Xeon E3 1220 V6 3.0 Ghz Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 3270.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Xeon E3 1220 V6 3.0 Ghz Socket 1151.jpg" },
new Type { Title = "Intel Xeon E3 1275v6 3.8 GHz Socket 1151", Product = Products.Single(g => g.Name == "CPU"), Price = 5710.010M, Brand = Brands.Single(a => a.Name == "INTEL"), TypeArtUrl = "/Content/Images/Intel Xeon E3 1275v6 3.8 GHz Socket 1151.jpg" },


new Type { Title = "Asus N3150I C - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 1480.300M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus N3150I C - Carte Mère.jpg" },
new Type { Title = "Asrock J3455 ITX - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 1390.200M, Brand = Brands.Single(a => a.Name == "Asrock"), TypeArtUrl = "/Content/Images/Asrock J3455 ITX - Carte Mère.jpg" },
new Type { Title = "Asrock J3355B ITX - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 1100.300M, Brand = Brands.Single(a => a.Name == "Asrock"), TypeArtUrl = "/Content/Images/Asrock J3355B ITX - Carte Mère.jpg" },
new Type { Title = "Asrock J4205 ITX - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 1660.300M, Brand = Brands.Single(a => a.Name == "Asrock"), TypeArtUrl = "/Content/Images/Asrock J4205 ITX - Carte Mère.jpg" },
new Type { Title = "Asus J1800I - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 1140.300M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus J1800I - Carte Mère.jpg" },
new Type { Title = "MSI B360M PRO VH Socket 1151 - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 1060.300M, Brand = Brands.Single(a => a.Name == "MSI"), TypeArtUrl = "/Content/Images/MSI B360M PRO VH Socket 1151 - Carte Mère.jpg" },
new Type { Title = "Asus ROG Maximus IX Extreme Socket 1151 - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 4830.300M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus ROG Maximus IX Extreme Socket 1151 - Carte Mère.jpg" },
//new Type { Title = "Gigabyte Z370 HD3P Socket 1151 - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 1930.300M, Brand = Brands.Single(a => a.Name == "Gigabyte"), TypeArtUrl = "/Content/Images/Gigabyte Z370 HD3P Socket 1151 - Carte Mère.jpg" },
//new Type { Title = "EVGA Z170 Classified Socket 1151 - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 6600.400M, Brand = Brands.Single(a => a.Name == "EVGA"), TypeArtUrl = "/Content/Images/EVGA Z170 Classified Socket 1151 - Carte Mère.jpg" },
new Type { Title = "Asus ROG Strix Z370 I Gaming Socket 1151 - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 3180.300M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus ROG Strix Z370 I Gaming Socket 1151 - Carte Mère.jpg" },
new Type { Title = "Asus Prime Z270 P Socket 1151 - Carte Mère", Product = Products.Single(g => g.Name == "MotherBoard"), Price = 1780.300M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus Prime Z270 P Socket 1151 - Carte Mère.jpg" },





new Type { Title = "Corsair XMS3 DDR3 8GB (1x8GB) 1333Mhz CL9 - Mémoire RAM", Product = Products.Single(g => g.Name == "RAM"), Price = 940.300M, Brand = Brands.Single(a => a.Name == "Corsair"), TypeArtUrl = "/Content/Images/Corsair XMS3 DDR3 8GB (1x8GB) 1333Mhz CL9 - Mémoire RAM.jpg" },
new Type { Title = "Kingston HyperX Fury White 8GB 1600 MHz (PC3 12800) CL10 - Mémoire RAM", Product = Products.Single(g => g.Name == "RAM"), Price = 1080.300M, Brand = Brands.Single(a => a.Name == "Kingston"), TypeArtUrl = "/Content/Images/Kingston HyperX Fury White 8GB 1600 MHz (PC3 12800) CL10 - Mémoire RAM.jpg" },
new Type { Title = "Kingston HyperX Fury 8GB 1600 MHz (PC3 12800) CL10 - Mémoire RAM", Product = Products.Single(g => g.Name == "RAM"), Price = 940.300M, Brand = Brands.Single(a => a.Name == "Kingston"), TypeArtUrl = "/Content/Images/Kingston HyperX Fury 8GB 1600 MHz (PC3 12800) CL10 - Mémoire RAM.jpg" },
new Type { Title = "Kingston HyperX Savage 16GB (2x8GB) 2133 MHz (PC3 17000) CL11 - Mémoire RAM", Product = Products.Single(g => g.Name == "RAM"), Price = 2070.300M, Brand = Brands.Single(a => a.Name == "Kingston"), TypeArtUrl = "/Content/Images/Kingston HyperX Savage 16GB (2x8GB) 2133 MHz (PC3 17000) CL11 - Mémoire RAM.jpg" },
new Type { Title = "Crucial 8GB 1866 MHz (PC3 14900) CL13 Pour Mac - Mémoire RAM", Product = Products.Single(g => g.Name == "RAM"), Price = 1580.300M, Brand = Brands.Single(a => a.Name == "Crucial"), TypeArtUrl = "/Content/Images/Crucial 8GB 1866 MHz (PC3 14900) CL13 Pour Mac - Mémoire RAM.jpg" },
new Type { Title = "Kingston KVR16N11-8 8GB 1600 MHz (PC3 12800) CL11 - Mémoire RAM", Product = Products.Single(g => g.Name == "RAM"), Price = 920.300M, Brand = Brands.Single(a => a.Name == "Kingston"), TypeArtUrl = "/Content/Images/Kingston KVR16N11-8 8GB 1600 MHz (PC3 12800) CL11 - Mémoire RAM.jpg" },


new Type { Title = "Cooler Master SickleFlow LED Bleu - Ventilateur 12 cm", Product = Products.Single(g => g.Name == "Cooler"), Price = 210.500M, Brand = Brands.Single(a => a.Name == "Cooler Master"), TypeArtUrl = "/Content/Images/Cooler Master SickleFlow LED Bleu - Ventilateur 12 cm.jpg" },
new Type { Title = "DeepCool Marco Goma - Ventilateur 14 cm", Product = Products.Single(g => g.Name == "Cooler"), Price = 200.500M, Brand = Brands.Single(a => a.Name == "DeepCool"), TypeArtUrl = "/Content/Images/DeepCool Marco Goma - Ventilateur 14 cm.jpg" },
new Type { Title = "Coolink SWIF2 1201 - Ventilateur 12 cm", Product = Products.Single(g => g.Name == "Cooler"), Price = 210.500M, Brand = Brands.Single(a => a.Name == "Coolink"), TypeArtUrl = "/Content/Images/Coolink SWIF2 1201 - Ventilateur 12 cm.jpg" },
new Type { Title = "Corsair AF120 Quiet Edition - Ventilateur 12 cm", Product = Products.Single(g => g.Name == "Cooler"), Price = 390.500M, Brand = Brands.Single(a => a.Name == "Corsair"), TypeArtUrl = "/Content/Images/Corsair AF120 Quiet Edition - Ventilateur 12 cm.jpg" },
new Type { Title = "Airen hAiBrid Wings 120E POWER - Ventilateur 12 cm", Product = Products.Single(g => g.Name == "Cooler"), Price = 190.500M, Brand = Brands.Single(a => a.Name == "Airen"), TypeArtUrl = "/Content/Images/Airen hAiBrid Wings 120E POWER - Ventilateur 12 cm.jpg" },
new Type { Title = "Corsair Air Series AF120 LN Dual Pack - Ventilateur 12 cm", Product = Products.Single(g => g.Name == "Cooler"), Price = 450.500M, Brand = Brands.Single(a => a.Name == "Corsair"), TypeArtUrl = "/Content/Images/Corsair Air Series AF120 LN Dual Pack - Ventilateur 12 cm.jpg" },
new Type { Title = "NZXT FZ 120 LED Bleu - Ventilateur 12 cm", Product = Products.Single(g => g.Name == "Cooler"), Price = 210.500M, Brand = Brands.Single(a => a.Name == "NZXT"), TypeArtUrl = "/Content/Images/NZXT FZ 120 LED Bleu - Ventilateur 12 cm.jpg" },



            new Type { Title = "Creative Sound Blaster ZX PCI e", Product = Products.Single(g => g.Name == "Speaker"), Price = 1440.500M, Brand = Brands.Single(a => a.Name == "Creative Sound Blaster"), TypeArtUrl = "/Content/Images/Creative Sound Blaster ZX PCI e.jpg" },
            new Type { Title = "Creative Sound BlasterX AE 5", Product = Products.Single(g => g.Name == "Speaker"), Price = 2440.500M, Brand = Brands.Single(a => a.Name == "Creative Sound Blaster"), TypeArtUrl = "/Content/Images/Creative Sound BlasterX AE 5.jpg" },
            new Type { Title = "Asus Strix Raid PRO 7.1 PCIe Gaming", Product = Products.Single(g => g.Name == "Speaker"), Price = 2330.500M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus Strix Raid PRO 7.1 PCIe Gaming.jpg" },
            new Type { Title = "Startech 5.1 PCI", Product = Products.Single(g => g.Name == "Speaker"), Price = 380.500M, Brand = Brands.Single(a => a.Name == "Startech"), TypeArtUrl = "/Content/Images/Startech 5.1 PCI.jpg" },
            new Type { Title = "Asus Xonar Essence STX II 5.1 PCIe", Product = Products.Single(g => g.Name == "Speaker"), Price = 3050.500M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus Xonar Essence STX II 5.1 PCIe.jpg" },
            new Type { Title = "Creative Sound Blaster Audigy RX", Product = Products.Single(g => g.Name == "Speaker"), Price = 940.500M, Brand = Brands.Single(a => a.Name == "Creative Sound Blaster"), TypeArtUrl = "/Content/Images/Creative Sound Blaster Audigy RX.jpg" },
            new Type { Title = "Asus Xonar DG 5.1", Product = Products.Single(g => g.Name == "Speaker"), Price = 1440.500M, Brand = Brands.Single(a => a.Name == "ASUS"), TypeArtUrl = "/Content/Images/Asus Xonar DG 5.1.jpg" },
            }.ForEach(a => context.Types.Add(a));
        }
    }
}