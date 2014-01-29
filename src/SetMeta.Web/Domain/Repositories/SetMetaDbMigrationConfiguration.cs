using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Permissions;
using SetMeta.Web.Helpers;
using SetMeta.Web.Domain.Entities;

namespace SetMeta.Web.Domain.Repositories
{
    public class SetMetaDbMigrationConfiguration : DbMigrationsConfiguration<SetMetaDbContext>
    {
        public SetMetaDbMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SetMetaDbContext context)
        {
            if (context.Users.Any()) return;

            #region Users

            AddAdmin(context, "Serdar Büyüktemiz", "hserdarb@gmail.com");
            AddAdmin(context, "Caner Çavuş", "canercvs@gmail.com");
            AddAdmin(context, "Ramiz Sümer", "ramiz.sumerr@gmail.com");
            AddAdmin(context, "Mehmet Sabancıoğlu", "mehmet.sabancioglu@gmail.com");
            AddAdmin(context, "Cihan Çoşkun", "cihancoskun@gmail.com");
            AddAdmin(context, "Kemal Çolak", "kml.colak@gmail.com");
            AddAdmin(context, "Duygu Sevim", "sevimduygu@gmail.com");

            //todo: temporary add myself as admin for tests
            AddAdmin(context, "Max Voloshin", "mx.voloshin@gmail.com");

            #endregion

            #region Months

            AddMonths(context, "January", "january", "1");
            AddMonths(context, "February", "february", "2");
            AddMonths(context, "March", "march", "3");
            AddMonths(context, "April", "april", "4");
            AddMonths(context, "May", "may", "5");
            AddMonths(context, "June", "june", "6");
            AddMonths(context, "July", "july", "7");
            AddMonths(context, "August", "august", "8");
            AddMonths(context, "September", "september", "9");
            AddMonths(context, "October", "october", "10");
            AddMonths(context, "November", "november", "11");
            AddMonths(context, "December", "december", "12");

            #endregion

            #region Vehicle Types

            AddVehicleType(context, "Automobile", "automobile", "1");
            AddVehicleType(context, "SUVs & Pick-Up Trucks", "suvs_pick_up_trucks", "2");
            AddVehicleType(context, "Motorcyles", "motorcycles", "3");
            AddVehicleType(context, "Minivans, Vans & Panelvans", "minivans_vans_panelvans", "4");
            AddVehicleType(context, "ATV", "atv", "5");
            AddVehicleType(context, "UTV", "utv", "6");
            AddVehicleType(context, "Electric Vehicles", "electric_vehicles", "7");
            AddVehicleType(context, "RVs & Campers", "rvs_campers", "8");


            #endregion

            #region Car Brands

            AddCarBrand(context, "Acura", "acura", "www.acura.com");
            AddCarBrand(context, "Alfa Romeo", "alfa_romeo", "www.alfaromeo.com");
            AddCarBrand(context, "Aston Martin", "aston_martin", "www.astonmartin.com");
            AddCarBrand(context, "Audi", "audi", "www.audi.com");
            AddCarBrand(context, "Bentley", "bentley", "www.bentleymotors.com");
            AddCarBrand(context, "BMW", "bmw", "www.bmw.com");
            AddCarBrand(context, "Bugatti", "bugatti", "www.bugatti.com");
            AddCarBrand(context, "Buick", "buick", "www.buick.com");
            AddCarBrand(context, "Cadillac", "cadillac", "www.cadillac.com");
            AddCarBrand(context, "Chery", "chery", "www.chery.com");
            AddCarBrand(context, "Chevrolet", "chevrolet", "www.chevrolet.com");
            AddCarBrand(context, "Chrysler", "chrysler", "www.chrysler.com");
            AddCarBrand(context, "Citroën", "citroen", "www.citroen.com");
            AddCarBrand(context, "Dacia", "dacia", "www.dacia.com");
            AddCarBrand(context, "Daewoo", "daewoo", "www.daewoous.com");
            AddCarBrand(context, "Daihatsu", "daihatsu", "www.daihatsu.com");
            AddCarBrand(context, "Dodge", "dodge", "www.dodge.com");
            AddCarBrand(context, "Eagle", "eagle", "www.eagleautonz.com");
            AddCarBrand(context, "Ferrari", "ferrari", "www.ferrari.com");
            AddCarBrand(context, "Fiat", "fiat", "www.fiat.com");
            AddCarBrand(context, "Ford", "ford", "www.ford.com");
            AddCarBrand(context, "GAZ", "gaz", "eng.gazgroup.ru");
            AddCarBrand(context, "Geely", "geely", "www.geely.com");
            AddCarBrand(context, "Gumpert", "gumpert", "www.gumpert.de");
            AddCarBrand(context, "Hennessey", "hennessey", "www.hennesseyperformance.com");
            AddCarBrand(context, "Honda", "honda", "honda.com");
            AddCarBrand(context, "Hyundai", "hyundai", "www.hyundai.com");
            AddCarBrand(context, "Ikco", "ikco", "www.ikco.com");
            AddCarBrand(context, "Infiniti", "infiniti", "www.infiniti.com");
            AddCarBrand(context, "Isuzu", "isuzu", "www.isuzu.com");
            AddCarBrand(context, "Jaguar", "jaguar", "www.jaguar.com");
            AddCarBrand(context, "Kia", "kia", "www.kia.com");
            AddCarBrand(context, "Lada", "lada", "www.lada.com");
            AddCarBrand(context, "Lamborghini", "lamborghini", "www.lamborghini.com");
            AddCarBrand(context, "Lancia", "lancia", "www.lancia.com");
            AddCarBrand(context, "Lexus", "lexus", "www.lexus.com");
            AddCarBrand(context, "Lincoln", "lincoln", "www.lincoln.com");
            AddCarBrand(context, "Lotus", "lotus", "www.lotuscars.com");
            AddCarBrand(context, "Maserati", "maserati", "www.maserati.com");
            AddCarBrand(context, "Mazda", "mazda", "www.mazda.com");
            AddCarBrand(context, "McLaren", "mclaren", "www.mclaren.com");
            AddCarBrand(context, "Mercedes - Benz", "mercedes_benz", "www.mercedes-benz.com");
            AddCarBrand(context, "Mercury", "mercury", "www.mercuryvehicles.com");
            AddCarBrand(context, "MG", "mg", "mg.co.uk");
            AddCarBrand(context, "Mini", "mini", "www.mini.com");
            AddCarBrand(context, "Mitsubishi", "mitsubishi", "www.mitsubishi-motors.com");
            AddCarBrand(context, "Nissan", "nissan", "www.nissan-global.com");
            AddCarBrand(context, "Oldsmobile", "oldsmobile", "www.oldsmobile.com");
            AddCarBrand(context, "Opel", "opel", "www.opel.com");
            AddCarBrand(context, "Peugeot", "peugeot", "www.peugeot.com");
            AddCarBrand(context, "Pontiac", "pontiac", "www.pontiac.com");
            AddCarBrand(context, "Porsche", "porsche", "www.porsche.com");
            AddCarBrand(context, "Proton", "proton", "www.proton.com");
            AddCarBrand(context, "Renault", "renault", "www.renault.com");
            AddCarBrand(context, "Rolls-Royce", "rolls_royce", "www.rolls-roycemotorcars.com");
            AddCarBrand(context, "Saab", "saab", "www.saab.com");
            AddCarBrand(context, "Seat", "seat", "www.seat.com");
            AddCarBrand(context, "Skoda", "skoda", "www.skoda-auto.com");
            AddCarBrand(context, "Smart", "smart", "www.smart.com");
            AddCarBrand(context, "Subaru", "subaru", "www.subaru-global.com");
            AddCarBrand(context, "Suzuki", "suzuki", "www.suzuki.com");
            AddCarBrand(context, "Şamil", "samil", "www.samil.com");
            AddCarBrand(context, "Tata", "tata", "www.tatamotors.com");
            AddCarBrand(context, "Toyota", "toyota", "www.toyota.com");
            AddCarBrand(context, "Volkswagen", "volkswagen", "www.vw.com");
            AddCarBrand(context, "Volvo", "volvo", "www.volvo.com");

            #endregion

            #region Payment Type

            AddPaymentType(context, "Credit Card", "credit_card");
            AddPaymentType(context, "Cash", "cash");

            #endregion

            #region Currency

            AddCurrency(context, "Afghan Afghani", "AFN");
            AddCurrency(context, "Albanian Lek", "ALL");
            AddCurrency(context, "Armenian Dram", "AMD");
            AddCurrency(context, "Dutch Guilder", "ANG");
            AddCurrency(context, "Angolan Kwanza", "AOA");
            AddCurrency(context, "Argentine Peso", "ARS");
            AddCurrency(context, "Australian Dollar", "AUD");
            AddCurrency(context, "Aruban or Dutch Guilder", "AWG");
            AddCurrency(context, "Azerbaijani New Manat", "AZN");
            AddCurrency(context, "Bosnian Convertible Marka", "BAM");
            AddCurrency(context, "Barbadian or Bajan Dollar", "BBD");
            AddCurrency(context, "Bangladeshi Taka", "BDT");
            AddCurrency(context, "Bulgarian Lev", "BGN");
            AddCurrency(context, "Bahraini Dinar", "BHD");
            AddCurrency(context, "Burundian Franc", "BIF");
            AddCurrency(context, "Bermudian Dollar", "BMD");
            AddCurrency(context, "Bruneian Dollar", "BND");
            AddCurrency(context, "Bolivian Boliviano", "BOB");
            AddCurrency(context, "Brazilian Real", "BRL");
            AddCurrency(context, "Bahamian Dollar", "BSD");
            AddCurrency(context, "Bhutanese Ngultrum", "BTN");
            AddCurrency(context, "Botswana Pula", "BWP");
            AddCurrency(context, "Belarusian Ruble", "BYR");
            AddCurrency(context, "Belizean Dollar", "BZD");
            AddCurrency(context, "Canadian Dollar", "CAD");
            AddCurrency(context, "Congolese Franc", "CDF");
            AddCurrency(context, "Swiss Franc", "CHF");
            AddCurrency(context, "Chilean Peso", "CLP");
            AddCurrency(context, "Chinese Yuan Renminbi", "CNY");
            AddCurrency(context, "Colombian Peso", "COP");
            AddCurrency(context, "Costa Rican Colon", "CRC");
            AddCurrency(context, "Cuban Convertible Peso", "CUC");
            AddCurrency(context, "Cuban Peso", "CUP");
            AddCurrency(context, "Cape Verdean Escudo", "CVE");
            AddCurrency(context, "Czech Koruna", "CZK");
            AddCurrency(context, "Djiboutian Franc", "DJF");
            AddCurrency(context, "Danish Krone", "DKK");
            AddCurrency(context, "Dominican Peso", "DOP");
            AddCurrency(context, "Algerian Dinar", "DZD");
            AddCurrency(context, "Egyptian Pound", "EGP");
            AddCurrency(context, "Eritrean Nakfa", "ERN");
            AddCurrency(context, "Ethiopian Birr", "ETB");
            AddCurrency(context, "Euro", "EUR ");
            AddCurrency(context, "Fijian Dollar", "FJD");
            AddCurrency(context, "Falkland Island Pound", "FKP");
            AddCurrency(context, "British Pound", "GBP");
            AddCurrency(context, "Georgian Lari", "GEL");
            AddCurrency(context, "Guernsey Pound", "GGP");
            AddCurrency(context, "Ghanaian Cedi", "GHS");
            AddCurrency(context, "Gibraltar Pound", "GIP");
            AddCurrency(context, "Gambian Dalasi", "GMD");
            AddCurrency(context, "Guinean Franc", "GNF");
            AddCurrency(context, "Guatemalan Quetzal", "GTQ");
            AddCurrency(context, "Guyanese Dollar", "GYD");
            AddCurrency(context, "Hong Kong Dollar", "HKD");
            AddCurrency(context, "Honduran Lempira", "HNL");
            AddCurrency(context, "Croatian Kuna", "HRK");
            AddCurrency(context, "Haitian Gourde", "HTG");
            AddCurrency(context, "Hungarian Forint", "HUF");
            AddCurrency(context, "Indonesian Rupiah", "IDR");
            AddCurrency(context, "Israeli Shekel", "ILS");
            AddCurrency(context, "Isle of Man Pound", "IMP");
            AddCurrency(context, "Indian Rupee", "INR");
            AddCurrency(context, "Iraqi Dinar", "IQD");
            AddCurrency(context, "Iranian Rial", "IRR");
            AddCurrency(context, "Icelandic Krona", "ISK");
            AddCurrency(context, "Jersey Pound", "JEP");
            AddCurrency(context, "Jamaican Dollar", "JMD");
            AddCurrency(context, "Jordanian Dinar", "JOD");
            AddCurrency(context, "Japanese Yen", "JPY");
            AddCurrency(context, "Kenyan Shilling", "KES");
            AddCurrency(context, "Kyrgyzstani Som", "KGS");
            AddCurrency(context, "Cambodian Riel", "KHR");
            AddCurrency(context, "Comoran Franc", "KMF");
            AddCurrency(context, "North Korean Won", "KPW");
            AddCurrency(context, "South Korean Won", "KRW");
            AddCurrency(context, "Kuwaiti Dinar", "KWD");
            AddCurrency(context, "Caymanian Dollar", "KYD");
            AddCurrency(context, "Kazakhstani Tenge", "KZT");
            AddCurrency(context, "Lao or Laotian Kip", "LAK");
            AddCurrency(context, "Lebanese Pound", "LBP");
            AddCurrency(context, "Sri Lankan Rupee", "LKR");
            AddCurrency(context, "Liberian Dollar", "LRD");
            AddCurrency(context, "Basotho Loti", "LSL");
            AddCurrency(context, "Lithuanian Litas", "LTL");
            AddCurrency(context, "Latvian Lat", "LVL");
            AddCurrency(context, "Libyan Dinar", "LYD");
            AddCurrency(context, "Moroccan Dirham", "MAD");
            AddCurrency(context, "Moldovan Leu", "MDL");
            AddCurrency(context, "Malagasy Ariary", "MGA");
            AddCurrency(context, "Macedonian Denar", "MKD");
            AddCurrency(context, "Burmese Kyat", "MMK");
            AddCurrency(context, "Mongolian Tughrik", "MNT");
            AddCurrency(context, "Macau Pataca", "MOP");
            AddCurrency(context, "Mauritanian Ouguiya", "MRO");
            AddCurrency(context, "Mauritian Rupee", "MUR");
            AddCurrency(context, "Maldivian Rufiyaa", "MVR");
            AddCurrency(context, "Malawian Kwacha", "MWK");
            AddCurrency(context, "Mexican Peso", "MXN");
            AddCurrency(context, "Malaysian Ringgit", "MYR");
            AddCurrency(context, "Mozambican Metical", "MZN");
            AddCurrency(context, "Namibian Dollar", "NAD");
            AddCurrency(context, "Nigerian Naira", "NGN");
            AddCurrency(context, "Nicaraguan Cordoba", "NIO");
            AddCurrency(context, "Norwegian Krone", "NOK");
            AddCurrency(context, "Nepalese Rupee", "NPR");
            AddCurrency(context, "New Zealand Dollar", "NZD");
            AddCurrency(context, "Omani Rial", "OMR");
            AddCurrency(context, "Panamanian Balboa", "PAB");
            AddCurrency(context, "Peruvian Nuevo Sol", "PEN");
            AddCurrency(context, "Papua New Guinean Kina", "PGK");
            AddCurrency(context, "Philippine Peso", "PHP");
            AddCurrency(context, "Pakistani Rupee", "PKR");
            AddCurrency(context, "Polish Zloty", "PLN");
            AddCurrency(context, "Paraguayan Guarani", "PYG");
            AddCurrency(context, "Qatari Riyal", "QAR");
            AddCurrency(context, "Romanian New Leu", "RON");
            AddCurrency(context, "Serbian Dinar", "RSD");
            AddCurrency(context, "Russian Ruble", "RUB");
            AddCurrency(context, "Rwandan Franc", "RWF");
            AddCurrency(context, "Saudi Arabian Riyal", "SAR");
            AddCurrency(context, "Solomon Islander Dollar", "SBD");
            AddCurrency(context, "Seychellois Rupee", "SCR");
            AddCurrency(context, "Sudanese Pound", "SDG");
            AddCurrency(context, "Swedish Krona", "SEK");
            AddCurrency(context, "Singapore Dollar", "SGD");
            AddCurrency(context, "Saint Helenian Pound", "SHP");
            AddCurrency(context, "Sierra Leonean Leone", "SLL");
            AddCurrency(context, "Somali Shilling", "SOS");
            AddCurrency(context, "Seborgan Luigino", "SPL");
            AddCurrency(context, "Surinamese Dollar", "SRD");
            AddCurrency(context, "Sao Tomean Dobra", "STD");
            AddCurrency(context, "Salvadoran Colon", "SVC");
            AddCurrency(context, "Syrian Pound", "SYP");
            AddCurrency(context, "Swazi Lilangeni", "SZL");
            AddCurrency(context, "Thai Baht", "THB");
            AddCurrency(context, "Tajikistani Somoni", "TJS");
            AddCurrency(context, "Turkmenistani Manat", "TMT");
            AddCurrency(context, "Tunisian Dinar", "TND");
            AddCurrency(context, "Tongan Pa'anga", "TOP");
            AddCurrency(context, "Turkish Lira", "TRY");
            AddCurrency(context, "Trinidadian Dollar", "TTD");
            AddCurrency(context, "Tuvaluan Dollar", "TVD");
            AddCurrency(context, "Taiwan New Dollar", "TWD");
            AddCurrency(context, "Tanzanian Shilling", "TZS");
            AddCurrency(context, "Ukrainian Hryvna", "UAH");
            AddCurrency(context, "Ugandan Shilling", "UGX");
            AddCurrency(context, "US Dollar", "USD");
            AddCurrency(context, "Uruguayan Peso", "UYU");
            AddCurrency(context, "Uzbekistani Som", "UZS");
            AddCurrency(context, "Venezuelan Bolivar", "VEF");
            AddCurrency(context, "Vietnamese Dong", "VND");
            AddCurrency(context, "Ni-Vanuatu Vatu", "VUV");
            AddCurrency(context, "Samoan Tala", "WST");
            AddCurrency(context, "Central African CFA Franc BEAC", "XAF");
            AddCurrency(context, "Silver Ounce", "XAG");
            AddCurrency(context, "Gold Ounce", "XAU");
            AddCurrency(context, "Bitcoin", "XBT");
            AddCurrency(context, "East Caribbean Dollar", "XCD");
            AddCurrency(context, "IMF Special Drawing Rights", "XDR");
            AddCurrency(context, "CFA Franc", "XOF");
            AddCurrency(context, "Palladium Ounce", "XPD");
            AddCurrency(context, "CFP Franc", "XPF");
            AddCurrency(context, "Platinum Ounce", "XPT");
            AddCurrency(context, "Yemeni Rial", "YER");
            AddCurrency(context, "South African Rand", "ZAR");
            AddCurrency(context, "Zambian Kwacha", "ZMW");
            AddCurrency(context, "Zimbabwean Dollar", "ZWD ");

            #endregion

            #region Timezones

            AddTimezone(context, "UTC−12:00", "utc_minus_twelve");
            AddTimezone(context, "UTC−11:00", "utc_minus_eleven");
            AddTimezone(context, "UTC−10:00", "utc_minus_ten");
            AddTimezone(context, "UTC−09:30", "utc_minus_half_past_nine");
            AddTimezone(context, "UTC−09:00", "utc_minus_nine");
            AddTimezone(context, "UTC−08:00", "utc_minus_eight");
            AddTimezone(context, "UTC−07:00", "utc_minus_seven");
            AddTimezone(context, "UTC−06:00", "utc_minus_six");
            AddTimezone(context, "UTC−05:00", "utc_minus_five");
            AddTimezone(context, "UTC−04:30", "utc_minus_half_past_four");
            AddTimezone(context, "UTC−04:00", "utc_minus_four");
            AddTimezone(context, "UTC−03:30", "utc_minus_half_past_three");
            AddTimezone(context, "UTC−03:00", "utc_minus_three");
            AddTimezone(context, "UTC−02:00", "utc_minus_two");
            AddTimezone(context, "UTC−01:00", "utc_minus_one");
            AddTimezone(context, "UTC±00:00", "utc_zero");
            AddTimezone(context, "UTC+01:00", "utc_plus_one");
            AddTimezone(context, "UTC+02:00", "utc_plus_two");
            AddTimezone(context, "UTC+03:00", "utc_plus_three");
            AddTimezone(context, "UTC+03:30", "utc_plus_half_past_three");
            AddTimezone(context, "UTC+04:00", "utc_plus_four");
            AddTimezone(context, "UTC+04:30", "utc_plus_half_past_four");
            AddTimezone(context, "UTC+05:00", "utc_plus_five");
            AddTimezone(context, "UTC+05:30", "utc_plus_half_past_five");
            AddTimezone(context, "UTC+05:45", "utc_plus_a_quarter_to_five");
            AddTimezone(context, "UTC+06:00", "utc_plus_six");
            AddTimezone(context, "UTC+06:30", "utc_plus_half_past_six");
            AddTimezone(context, "UTC+07:00", "utc_plus_seven");
            AddTimezone(context, "UTC+08:00", "utc_plus_eight");
            AddTimezone(context, "UTC+08:45", "utc_plus_a_quarter_to_nine");
            AddTimezone(context, "UTC+09:00", "utc_plus_nine");
            AddTimezone(context, "UTC+09:30", "utc_plus_half_past_nine");
            AddTimezone(context, "UTC+10:00", "utc_plus_ten");
            AddTimezone(context, "UTC+10:30", "utc_plus_half_past_ten");
            AddTimezone(context, "UTC+11:00", "utc_plus_eleven");
            AddTimezone(context, "UTC+11:30", "utc_plus_half_past_eleven");
            AddTimezone(context, "UTC+12:00", "utc_plus_twelve");
            AddTimezone(context, "UTC+12:45", "utc_plus_a_quarter_to_thirteen");
            AddTimezone(context, "UTC+13:00", "utc_plus_thirteen");
            AddTimezone(context, "UTC+14:00", "utc_plus_fourteen");

            #endregion

            #region Quarters

            AddQuarter(context, "First Quarter", "first_quarter");
            AddQuarter(context, "Second Quarter", "second_quarter");
            AddQuarter(context, "Third Quarter", "third_quarter");
            AddQuarter(context, "Fourth Quarter", "fourth_quarter");

            #endregion

            #region Credit Card

            AddCreditCard(context, "American Express", "american_express");
            AddCreditCard(context, "Diners Club", "diners_club");
            AddCreditCard(context, "MasterCard", "master_card");
            AddCreditCard(context, "Visa", "visa");

            #endregion

            #region Banks Of World (Eklenicek)


            #endregion


            #region MeasurementUnit

            AddMeasurementUnit(context, "Kilometer per second squared", " Acceleration", "km/s²");
            AddMeasurementUnit(context, "bit per second", " Data transfer rate", "bps");
            AddMeasurementUnit(context, "Kilobit per second", " Data transfer rate", "kbps");
            AddMeasurementUnit(context, "Gram per litre", " Density", "g/L");
            AddMeasurementUnit(context, " Gram per millilitre", "Density", "g/mL");
            AddMeasurementUnit(context, "Giga", " Franctions and Percent", "g");
            AddMeasurementUnit(context, "atomic mass unit", " Mass and weight", "amu");
            AddMeasurementUnit(context, "Hectopascal", " Stress and Pressure", "hPa");
            AddMeasurementUnit(context, "Kilonewton per square meter", " Stress and Pressure", "kN/m²");
            AddMeasurementUnit(context, "Kilopascal", " Stress and Pressure", "kPa");
            AddMeasurementUnit(context, "Kilogram per square centimeter", " Stress and Pressure", "kgf/cm²");
            AddMeasurementUnit(context, "Kilogram per square meter", " Stress and Pressure", "kgf/m²");
            AddMeasurementUnit(context, "Foot per second squared ", "Acceleration", "ft/s²");
            AddMeasurementUnit(context, "Galileo", "Acceleration", "Gal");
            AddMeasurementUnit(context, "meter per second squared", "Acceleration", "m/s²");
            AddMeasurementUnit(context, "Millimeter per second squared", "Acceleration", "mm/s²");
            AddMeasurementUnit(context, "Standard acceleration of free fall on Earth", "Acceleration", "gn index");
            AddMeasurementUnit(context, "Inch per second squared", "Acceleration", "in/s²");
            AddMeasurementUnit(context, "Are", "Area", "a");
            AddMeasurementUnit(context, "Barn", "Area", "b");
            AddMeasurementUnit(context, "Square centimeter", "Area", "cm²");
            AddMeasurementUnit(context, "Square decimeter", "Area", "dm²");
            AddMeasurementUnit(context, "Square foot", "Area", "ft²");
            AddMeasurementUnit(context, "Square inch", "Area", "in²");
            AddMeasurementUnit(context, "Square kilometer", "Area", "km²");
            AddMeasurementUnit(context, "Planck area", "Area", "L²");
            AddMeasurementUnit(context, "Square meter", "Area", "m²");
            AddMeasurementUnit(context, "Square millimeter", "Area", "mm²");
            AddMeasurementUnit(context, "Barrel", "Capacity and volume", "bbl");
            AddMeasurementUnit(context, "Bushel", "Capacity and volume", "bu");
            AddMeasurementUnit(context, "Cubic centimeter", "Capacity and volume", "cc");
            AddMeasurementUnit(context, "centiliter", "Capacity and volume", "cl");
            AddMeasurementUnit(context, "Cubic decimeter", "Capacity and volume", "dm³");
            AddMeasurementUnit(context, "Cubic foot", "Capacity and volume", "ft³");
            AddMeasurementUnit(context, "Cubic inch ", "Capacity and volume", "in³");
            AddMeasurementUnit(context, "Cubic kilometer", "Capacity and volume", "km³");
            AddMeasurementUnit(context, "Cubic meter ", "Capacity and volume", "m³");
            AddMeasurementUnit(context, "Cubic millimeter", "Capacity and volume", "mm³");
            AddMeasurementUnit(context, "Cubic yard", "Capacity and volume", "yd³");
            AddMeasurementUnit(context, "Deciliter", "Capacity and volume", "dl");
            AddMeasurementUnit(context, "Fluid ounce", "Capacity and volume", "oz");
            AddMeasurementUnit(context, "Gallon", "Capacity and volume", "gal");
            AddMeasurementUnit(context, "Hectoliter", "Capacity and volume", "hl");
            AddMeasurementUnit(context, "Planck volume", "Capacity and volume", "L³");
            AddMeasurementUnit(context, "Liter", "Capacity and volume", "l");
            AddMeasurementUnit(context, "Microliter ", "Capacity and volume", "µl");
            AddMeasurementUnit(context, "Milliliter", "Capacity and volume", "ml");
            AddMeasurementUnit(context, "Peck", "Capacity and volume", "pk");
            AddMeasurementUnit(context, "Quart", "Capacity and volume", "qt");
            AddMeasurementUnit(context, "circumference", "Circular measure", "circle");
            AddMeasurementUnit(context, "Degree", "Circular measure", "deg");
            AddMeasurementUnit(context, "Grade", "Circular measure", "grad");
            AddMeasurementUnit(context, "Radian", "Circular measure", "rad");
            AddMeasurementUnit(context, "Exbibyte [exabyte]", "Computer Storage", "Eb [EiB]");
            AddMeasurementUnit(context, "Exabit [exbibit]", "Computer Storage", "Ebit [Eibit]");
            AddMeasurementUnit(context, "Gigabyte [gibibyte]", "Computer storage", "Gb [GiB]");
            AddMeasurementUnit(context, " Gigabit [gibibit]", "Computer storage", "Gbit [Gibit]");
            AddMeasurementUnit(context, "megabyte [mebibyte]", "Computer Storage", "Mb [MiB] ");
            AddMeasurementUnit(context, "megabit [mebibit]", "Computer Storage", "Mbit [Mibit]");
            AddMeasurementUnit(context, "Storage length in meters", "Computer Storage", "m");
            AddMeasurementUnit(context, "Terabit [tebibit] ", "computer Storage", "Tbit [Tibit]");
            AddMeasurementUnit(context, "Terabyte [tebibyte] ", "Computer Storage", "Tb [TiB]");
            AddMeasurementUnit(context, "Kilobyte [kibybyte]", "Computer storage", "Kb [KiB]");
            AddMeasurementUnit(context, "Kilobit [kibibit]", "Computer storage", "Kbit [Kibit]");
            AddMeasurementUnit(context, "byte per second", "Data transfer rate", "B/s ");
            AddMeasurementUnit(context, "Gigabyte per second", "Data transfer rate", "GB/s");
            AddMeasurementUnit(context, "Gigabit per second", "Data transfer rate", "Gbps");
            AddMeasurementUnit(context, "Kilobyte per second", "Data transfer rate", "KB/s");
            AddMeasurementUnit(context, "Megabyte per second", "Data transfer rate", "MB/s");
            AddMeasurementUnit(context, "megabit per second", "Data transfer rate", "Mbps");
            AddMeasurementUnit(context, "Terabyte per second", "Data transfer rate", "TB/s");
            AddMeasurementUnit(context, "Terabit per second (Tbps)", "Data transfer rate", "Tbps");
            AddMeasurementUnit(context, "Planck density", "Density", "L¯³M ");
            AddMeasurementUnit(context, "Pound per cubic foot", "Density", "lb/ft³");
            AddMeasurementUnit(context, "Pound per U.S. gallon", "Density", "lb/gal");
            AddMeasurementUnit(context, "Pound per cubic inch", "Density", "lb/in³");
            AddMeasurementUnit(context, "Pound per cubic yard", "Density", "lb/yd³");
            AddMeasurementUnit(context, "Milligram per cubic meter", "Density", "mg/m³");
            AddMeasurementUnit(context, "Ounce per cubic foot ", "Density", "oz/ft³");
            AddMeasurementUnit(context, "Ounce per cubic inch ", "Density", "oz/in³");
            AddMeasurementUnit(context, "Ounce per cubic yard ", "Density", "oz/yd³");
            AddMeasurementUnit(context, "Gram per cubic meter", "Density", "g/m³");
            AddMeasurementUnit(context, "Kilogram per litre", "Density", "kg/L");
            AddMeasurementUnit(context, "Kilogram per cubic meter", "Density", "kg/m³");
            AddMeasurementUnit(context, "astronomical unit", "Distance and Length", "au");
            AddMeasurementUnit(context, "Cable length", "Distance and Length", "cbl");
            AddMeasurementUnit(context, "Gunter's (surveyors') chain", "Distance and Length", "ch");
            AddMeasurementUnit(context, "Ramsden's (engineers') chain", "Distance and Length", "ch");
            AddMeasurementUnit(context, "Centimeter", "Distance and Length", "cm");
            AddMeasurementUnit(context, "Cubit", "Distance and Length", "cu");
            AddMeasurementUnit(context, "Decimeter", "Distance and Length", "dm");
            AddMeasurementUnit(context, "Fathom", "Distance and Length", "fath");
            AddMeasurementUnit(context, "Foot", "Distance and Length", "ft");
            AddMeasurementUnit(context, "Horizontal pitch", "Distance and Length", "HP");
            AddMeasurementUnit(context, "Hand", "Distance and Length", "hd");
            AddMeasurementUnit(context, "Horizontal pitch", "Distance and Length", "HP");
            AddMeasurementUnit(context, "Inch", "Distance and Length", "in");
            AddMeasurementUnit(context, "Kilometer", "Distance and Length", "km");
            AddMeasurementUnit(context, "Planck length", "Distance and Length", "L");
            AddMeasurementUnit(context, "meter", "Distance and Length", "m");
            AddMeasurementUnit(context, "Mile", "Distance and Length", "mi");
            AddMeasurementUnit(context, "Millimeter", "Distance and Length", "mm");
            AddMeasurementUnit(context, "Nanometer", "Distance and Length", "nm");
            AddMeasurementUnit(context, "Palm", "Distance and Length", "plm");
            AddMeasurementUnit(context, "Parsec", "Distance and Length", "pc");
            AddMeasurementUnit(context, "Point", "Distance and Length", "pt");
            AddMeasurementUnit(context, "Pixel", "Distance and Length", "px");
            AddMeasurementUnit(context, "Rod", "Distance and Length", "rd");
            AddMeasurementUnit(context, "Yard", "Distance and Length", "yd");
            AddMeasurementUnit(context, "billion barrel of oil equivalent", "Energy and Work", "BBOE");
            AddMeasurementUnit(context, "barrel of oil equivalent", "Energy and Work", "BOE");
            AddMeasurementUnit(context, "British Thermal Unit", "Energy and Work", "BTU");
            AddMeasurementUnit(context, "Calorie", "Energy and Work", "cal");
            AddMeasurementUnit(context, "Electronvolt", "Energy and Work", "eV");
            AddMeasurementUnit(context, "Foot-Pound", "Energy and Work", "ft*lbs");
            AddMeasurementUnit(context, "Gigatonne of oil equivalent", "Energy and Work", "Gtoe");
            AddMeasurementUnit(context, "Joule", "Energy and Work", "J");
            AddMeasurementUnit(context, "Kilobarrel of oil equivalent", "Energy and Work", "kBOE");
            AddMeasurementUnit(context, "Kilojoule", "Energy and Work", "kJ");
            AddMeasurementUnit(context, "Kilowatt hour", "Energy and Work", "kW*h");
            AddMeasurementUnit(context, "Kilocalorie", "Energy and Work", "kcal");
            AddMeasurementUnit(context, "Planck energy", "Energy and Work", "L²MT¯²");
            AddMeasurementUnit(context, "Megajoule", "Energy and Work", "MJ");
            AddMeasurementUnit(context, "Million BTU", "Energy and Work", "MMBTU");
            AddMeasurementUnit(context, "megacalorie", "Energy and Work", "Mcal");
            AddMeasurementUnit(context, "megatonne of oil equivalent", "Energy and Work", "Mtoe");
            AddMeasurementUnit(context, "Metre-kilogram", "Energy and Work", "mkg");
            AddMeasurementUnit(context, "Watt hour", "Energy and Work", "W*h");
            AddMeasurementUnit(context, "Watt second", "Energy and Work", "W*s");
            AddMeasurementUnit(context, "Gram per day", "Flow rate by mass", "g/day");
            AddMeasurementUnit(context, "Gram per hour", "Flow rate by mass", "g/hour");
            AddMeasurementUnit(context, "Kilogram per day", "Flow rate by mass", "kg/day");
            AddMeasurementUnit(context, "Kilogram per hour", "Flow rate by mass", "kg/hour");
            AddMeasurementUnit(context, "Kilogram per minute", "Flow rate by mass", "kg/min");
            AddMeasurementUnit(context, "Kilogram per second", "Flow rate by mass", "kg/s");
            AddMeasurementUnit(context, "Kilogram per year", "Flow rate by mass", "kg/year");
            AddMeasurementUnit(context, "Pound per day", "Flow rate by mass", "lb/day");
            AddMeasurementUnit(context, "Pound per second", "Flow rate by mass", "lb/s");
            AddMeasurementUnit(context, "Pound per minute", "Flow rate by mass", "lb/min");
            AddMeasurementUnit(context, "Pound per hour", "Flow rate by mass", "lb/hour");
            AddMeasurementUnit(context, " Gram per minute", "Flow rate by mass", "g/min");
            AddMeasurementUnit(context, "Gram per second", "Flow rate by mass", "g/s");
            AddMeasurementUnit(context, "Gram per year", "Flow rate by mass", "g/year");
            AddMeasurementUnit(context, "Cubic foot per second", "Flow rate by volume", "ft³/s");
            AddMeasurementUnit(context, "Cubic foot per minute", "Flow rate by volume", "ft³/min");
            AddMeasurementUnit(context, "Cubic foot per hour", "Flow rate by volume", "ft³/hour");
            AddMeasurementUnit(context, "Cubic foot per day", "Flow rate by volume", "ft³/day");
            AddMeasurementUnit(context, "Cubic foot per year", "Flow rate by volume", "ft³/year");
            AddMeasurementUnit(context, "Cubic inch per second", "Flow rate by volume", "in³/s");
            AddMeasurementUnit(context, "Cubic inch per minute", "Flow rate by volume", "in³/min");
            AddMeasurementUnit(context, "Cubic inch per hour", "Flow rate by volume", "in³/hour");
            AddMeasurementUnit(context, "Cubic inch per day", "Flow rate by volume", "in³/day");
            AddMeasurementUnit(context, "Cubic inch per year", "Flow rate by volume", "in³/year");
            AddMeasurementUnit(context, "Cubic meter per second", "Flow rate by volume", "m³/s");
            AddMeasurementUnit(context, "Cubic meter per minute", "Flow rate by volume", "m³/min");
            AddMeasurementUnit(context, "Cubic meter per hour", "Flow rate by volume", "m³/hour");
            AddMeasurementUnit(context, "Cubic meter per day", "Flow rate by volume", "m³/day");
            AddMeasurementUnit(context, "Cubic meter per year", "Flow rate by volume", "m³/year");
            AddMeasurementUnit(context, "U.S. gallon per day", "Flow rate by volume", "gal/day");
            AddMeasurementUnit(context, "U.S. gallon per year", "Flow rate by volume", "gal/year");
            AddMeasurementUnit(context, "U.S. gallon per hour", "Flow rate by volume", "gph");
            AddMeasurementUnit(context, "U.S. gallon per minute", "Flow rate by volume", "gpm");
            AddMeasurementUnit(context, "U.S. gallon per second", "Flow rate by volume", "gps");
            AddMeasurementUnit(context, "Liter per day", "Flow rate by volume", "l/day");
            AddMeasurementUnit(context, "Liter per hour", "Flow rate by volume", "l/hour");
            AddMeasurementUnit(context, "Liter per minute", "Flow rate by volume", "l/min");
            AddMeasurementUnit(context, "Liter per second", "Flow rate by volume", "l/s");
            AddMeasurementUnit(context, "Liter per year", "Flow rate by volume", "l/year");
            AddMeasurementUnit(context, "Dyne", "Force", "dyn");
            AddMeasurementUnit(context, "Grave-force", "Force", "Gf");
            AddMeasurementUnit(context, "Kilonewton", "Force", "kN");
            AddMeasurementUnit(context, "Kilogram-force", "Force", "kgf");
            AddMeasurementUnit(context, "Kilopond", "Force", "kp");
            AddMeasurementUnit(context, "Planck force", "Force", "LMT²");
            AddMeasurementUnit(context, "Pound-force", "Force", "lbf");
            AddMeasurementUnit(context, "Meganewton", "Force", "MN");
            AddMeasurementUnit(context, "Milligrave-force", "Force", "mGf");
            AddMeasurementUnit(context, "Millinewton", "Force", "mN");
            AddMeasurementUnit(context, "Micronewton ", "Force", "µN");
            AddMeasurementUnit(context, "Newton", "Force", "N");
            AddMeasurementUnit(context, "Atto", "Franctions and Percent", "a");
            AddMeasurementUnit(context, "Centil", "Franctions and Percent", "c");
            AddMeasurementUnit(context, "Deci", "Franctions and Percent", "d");
            AddMeasurementUnit(context, "Deka", "Franctions and Percent", "da");
            AddMeasurementUnit(context, "Exa", "Franctions and Percent", "E");
            AddMeasurementUnit(context, "Femto", "Franctions and Percent", "f");
            AddMeasurementUnit(context, "Hecto", "Franctions and Percent", "h");
            AddMeasurementUnit(context, "Half", "Franctions and Percent", "½");
            AddMeasurementUnit(context, "Kilo", "Franctions and Percent", "k");
            AddMeasurementUnit(context, "Mega", "Franctions and Percent", "M");
            AddMeasurementUnit(context, "milli", "Franctions and Percent", "m");
            AddMeasurementUnit(context, "Micro", "Franctions and Percent", "µ; mc");
            AddMeasurementUnit(context, "Micromole ", "Franctions and Percent", "µmol");
            AddMeasurementUnit(context, "Millimole", "Franctions and Percent", "mmol");
            AddMeasurementUnit(context, "Mole", "Franctions and Percent", "mol");
            AddMeasurementUnit(context, "Nano", "Franctions and Percent", "n");
            AddMeasurementUnit(context, "Tera", "Franctions and Percent", "T");
            AddMeasurementUnit(context, "Permille", "Franctions and Percent", "‰");
            AddMeasurementUnit(context, "Yotta", "Franctions and Percent", "Y");
            AddMeasurementUnit(context, "Zetta", "Franctions and Percent", "Z");
            AddMeasurementUnit(context, "Percent", "Franctions and Percent", "%");
            AddMeasurementUnit(context, "Carat", "Mass and weight", "ct");
            AddMeasurementUnit(context, "Dram", "Mass and weight", "dr");
            AddMeasurementUnit(context, "Pennyweight", "Mass and weight", "dwt");
            AddMeasurementUnit(context, "Gram", "Mass and weight", "g");
            AddMeasurementUnit(context, "Grain", "Mass and weight", "gr");
            AddMeasurementUnit(context, "Kilogram", "Mass and weight", "kg");
            AddMeasurementUnit(context, "Pound", "Mass and weight", "lb");
            AddMeasurementUnit(context, "Planck mass", "Mass and weight", "M");
            AddMeasurementUnit(context, "Microgram", "Mass and weight", "mcg");
            AddMeasurementUnit(context, "Milligram", "Mass and weight", "mg");
            AddMeasurementUnit(context, "Ounce ", "Mass and weight", "oz");
            AddMeasurementUnit(context, "Foot pound-force per second", "Power", "ft*lbf/s");
            AddMeasurementUnit(context, "Horsepower, electric", "Power", "hp(E)");
            AddMeasurementUnit(context, "Horsepower, mechanical (imperial)", "Power", "hp(I) ");
            AddMeasurementUnit(context, "Horsepower, metric", "Power", "hp(M)");
            AddMeasurementUnit(context, "Horsepower, boiler", "Power", "hp(S)");
            AddMeasurementUnit(context, "Kilowatt", "Power", "kW");
            AddMeasurementUnit(context, "Planck power", "Power", "L²MT¯³");
            AddMeasurementUnit(context, "Megawatt", "Power", "MW");
            AddMeasurementUnit(context, "Volt-ampere", "Power", "VA");
            AddMeasurementUnit(context, "Watt", "Power", "W");
            AddMeasurementUnit(context, "Centigrey", "Radiation", "cGy");
            AddMeasurementUnit(context, "Gray", "Radiation", "Gy");
            AddMeasurementUnit(context, "Milligray", "Radiation", "mGy");
            AddMeasurementUnit(context, "Milliroentgen", "Radiation", "mR");
            AddMeasurementUnit(context, "Millisievert", "Radiation", "mSv");
            AddMeasurementUnit(context, "Microgray ", "Radiation", "µGy");
            AddMeasurementUnit(context, "Microroentgen ", "Radiation", "µR");
            AddMeasurementUnit(context, "Microsievert ", "Radiation", "µSv");
            AddMeasurementUnit(context, "Becquerel ", "Radioactivity", "Bq");
            AddMeasurementUnit(context, "Curie", "Radioactivity", "Ci");
            AddMeasurementUnit(context, "Disintegrations per minute", "Radioactivity", "dpm");
            AddMeasurementUnit(context, "Gigabecquerel", "Radioactivity", "GBq");
            AddMeasurementUnit(context, "Kilobecquerel", "Radioactivity", "kBq");
            AddMeasurementUnit(context, "Megabecquerel", "Radioactivity", "MBq");
            AddMeasurementUnit(context, "Millicurie", "Radioactivity", "mCi");
            AddMeasurementUnit(context, "Microcurie", "Radioactivity", "µCi");
            AddMeasurementUnit(context, "Kilometer per second", "Speed", "km/s");
            AddMeasurementUnit(context, "meter per second", "Speed", "m/s");
            AddMeasurementUnit(context, "Mile per hour ", "Speed", "mph");
            AddMeasurementUnit(context, "Mile per hour ", "Speed", "mph");
            AddMeasurementUnit(context, "physical atmosphere", "Stress and Pressure", "atm");
            AddMeasurementUnit(context, "Planck pressure", "Stress and Pressure", "L¯¹MT¯²");
            AddMeasurementUnit(context, "Meganewton per square meter", "Stress and Pressure", "MN/m²");
            AddMeasurementUnit(context, "Megapascal", "Stress and Pressure", "Mpa");
            AddMeasurementUnit(context, "Newton per square centimeter", "Stress and Pressure", "N/cm²");
            AddMeasurementUnit(context, "Newton per square meter", "Stress and Pressure", "N/m²");
            AddMeasurementUnit(context, "Newton per square millimeter", "Stress and Pressure", "N/mm²");
            AddMeasurementUnit(context, "Pascal", "Stress and Pressure", "Pa");
            AddMeasurementUnit(context, "degrees Celsius ", "Temperature", "°C ");
            AddMeasurementUnit(context, "degrees Delisle ", "Temperature", "°D ");
            AddMeasurementUnit(context, "degrees Fahrenheit ", "Temperature", "°F ");
            AddMeasurementUnit(context, "degrees Newton ", "Temperature", "°N ");
            AddMeasurementUnit(context, "degrees Rømer ", "Temperature", "°R ");
            AddMeasurementUnit(context, "degrees Rankine ", "Temperature", "°RØ");
            AddMeasurementUnit(context, "degrees Reaumur", "Temperature", "°Re ");
            AddMeasurementUnit(context, "Kelvin", "Temperature", "K");
            AddMeasurementUnit(context, "Minute", "Time", "min");
            AddMeasurementUnit(context, "Second", "Time", "s");
            AddMeasurementUnit(context, "Planck time", "Time", "T");

            #endregion
        }

        private void AddMeasurementUnit(SetMetaDbContext context, string description, string type, string key)
        {
            var measurementUnit = new MeasurementUnit
            {
                Code = key,
                Description = description,
                Type = type
            };
            context.MeasurementUnits.Add(measurementUnit);
        }

        private void AddBank(SetMetaDbContext context, string name, string key, string tel, string fax, string url, string teleks, string eft, string swift)
        {
            var bank = new Bank
            {
                Code = key,
                Name = name,
                Tel = tel,
                Fax = fax,
                Url = url,
                Teleks = teleks,
                Eft = eft,
                Swift = swift
            };
            context.Banks.Add(bank);
        }

        private void AddCreditCard(SetMetaDbContext context, string name, string key)
        {
            var creditCard = new CreditCard
            {
                Code = key,
                Name = name
            };
            context.CreditCards.Add(creditCard);
        }

        private void AddQuarter(SetMetaDbContext context, string name, string key)
        {
            var quarter = new Quarter
            {
                Code = key,
                Name = name
            };
            context.Quarters.Add(quarter);
        }

        private void AddTimezone(SetMetaDbContext context, string name, string key)
        {
            var timezone = new Timezone
            {
                Code = key,
                Name = name
            };
            context.Timezones.Add(timezone);
        }

        private void AddCurrency(SetMetaDbContext context, string name, string key)
        {
            var currency = new Currency
            {
                Code = key,
                Name = name
            };
            context.Currencies.Add(currency);
        }

        private void AddPaymentType(SetMetaDbContext context, string name, string key)
        {
            var paymentType = new PaymentType
            {
                Code = key,
                Name = name
            };
            context.PaymentTypes.Add(paymentType);
        }

        private void AddCarBrand(SetMetaDbContext context, string name, string key, string url)
        {
            var carBrand = new CarBrand
            {
                Code = key,
                Name = name,
                Url = url
            };
            context.CarBrands.Add(carBrand);
        }

        private static void AddVehicleType(SetMetaDbContext context, string name, string key, string value)
        {
            var vehicleType = new VehicleType
            {
                Code = key,
                Name = name,
                Value = value
            };
            context.VehicleTypes.Add(vehicleType);
        }

        private void AddMonths(SetMetaDbContext context, string name, string key, string value)
        {
            var month = new Month
            {
                Code = key,
                Name = name,
                Value = value
            };
            context.Months.Add(month);
        }

        private static void AddAdmin(SetMetaDbContext context, string name, string email)
        {
            var user = new User
            {
                Email = email,
                Name = name,
                RoleId = SetLocaleRole.Admin.Value,
                RoleName = SetLocaleRole.Admin.ToString(),
                ImageUrl = GravatarHelper.GetGravatarURL(email, 35),
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password"),
                LastLoginAt = DateTime.Now,
                IsActive = true
            };
            context.Users.Add(user);
        }
    }
}