﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CFC.Util
{
    public static class NameGenerator
    {
        public static Random rnd = new Random();

        public static string GetCompanyName()
        {
            var lst = new List<string>();
            lst.Add("Exxon Mobil");
            lst.Add("Wal-Mart Stores");
            lst.Add("Chevron");
            lst.Add("ConocoPhillips");
            lst.Add("General Motors");
            lst.Add("General Electric");
            lst.Add("Berkshire Hathaway");
            lst.Add("Fannie Mae");
            lst.Add("Ford Motor");
            lst.Add("Hewlett-Packard");
            lst.Add("AT&T");
            lst.Add("Valero Energy");
            lst.Add("Bank of America Corp.");
            lst.Add("McKesson");
            lst.Add("Verizon Communications");
            lst.Add("J.P. Morgan Chase & Co.");
            lst.Add("Apple");
            lst.Add("CVS Caremark");
            lst.Add("International Business Machines");
            lst.Add("Citigroup");
            lst.Add("Cardinal Health");
            lst.Add("UnitedHealth Group");
            lst.Add("Kroger");
            lst.Add("Costco Wholesale");
            lst.Add("Freddie Mac");
            lst.Add("Wells Fargo");
            lst.Add("Procter & Gamble");
            lst.Add("Archer Daniels Midland");
            lst.Add("AmerisourceBergen");
            lst.Add("INTL FCStone");
            lst.Add("Marathon Petroleum");
            lst.Add("Walgreen");
            lst.Add("American International Group");
            lst.Add("MetLife");
            lst.Add("Home Depot");
            lst.Add("Medco Health Solutions");
            lst.Add("Microsoft");
            lst.Add("Target");
            lst.Add("Boeing");
            lst.Add("Pfizer");
            lst.Add("PepsiCo");
            lst.Add("Johnson & Johnson");
            lst.Add("State Farm Insurance Cos.");
            lst.Add("Dell");
            lst.Add("WellPoint");
            lst.Add("Caterpillar");
            lst.Add("Dow Chemical");
            lst.Add("United Technologies");
            lst.Add("Comcast");
            lst.Add("Kraft Foods");
            lst.Add("Intel");
            lst.Add("United Parcel Service");
            lst.Add("Best Buy");
            lst.Add("Lowe's");
            lst.Add("Prudential Financial");
            lst.Add("Amazon.com");
            lst.Add("Merck");
            lst.Add("Lockheed Martin");
            lst.Add("Coca-Cola");
            lst.Add("Express Scripts Holding");
            lst.Add("Sunoco");
            lst.Add("Enterprise Products Partners");
            lst.Add("Safeway");
            lst.Add("Cisco Systems");
            lst.Add("Sears Holdings");
            lst.Add("Walt Disney");
            lst.Add("Johnson Controls");
            lst.Add("Morgan Stanley");
            lst.Add("Sysco");
            lst.Add("FedEx");
            lst.Add("Abbott Laboratories");
            lst.Add("DuPont");
            lst.Add("Google");
            lst.Add("Hess");
            lst.Add("Supervalu");
            lst.Add("United Continental Holdings");
            lst.Add("Honeywell International");
            lst.Add("CHS");
            lst.Add("Humana");
            lst.Add("Goldman Sachs Group");
            lst.Add("Ingram Micro");
            lst.Add("Oracle");
            lst.Add("Delta Air Lines");
            lst.Add("Liberty Mutual Insurance Group");
            lst.Add("World Fuel Services");
            lst.Add("New York Life Insurance");
            lst.Add("Plains All American Pipeline");
            lst.Add("TIAA-CREF");
            lst.Add("Aetna");
            lst.Add("Sprint Nextel");
            lst.Add("News Corp.");
            lst.Add("General Dynamics");
            lst.Add("Allstate");
            lst.Add("HCA Holdings");
            lst.Add("American Express");
            lst.Add("Tyson Foods");
            lst.Add("Deere");
            lst.Add("Murphy Oil");
            lst.Add("Philip Morris International");
            lst.Add("Nationwide");

            var str = lst.OrderBy(xx => rnd.Next()).First();
            return str;
        }

        public static string GetLastName()
        {
            var lst = new List<string>();
            string str = string.Empty;
            lst.Add("Smith");
            lst.Add("Johnson");
            lst.Add("Williams");
            lst.Add("Jones");
            lst.Add("Brown");
            lst.Add("Davis");
            lst.Add("Miller");
            lst.Add("Wilson");
            lst.Add("Moore");
            lst.Add("Taylor");
            lst.Add("Anderson");
            lst.Add("Thomas");
            lst.Add("Jackson");
            lst.Add("White");
            lst.Add("Harris");
            lst.Add("Martin");
            lst.Add("Thompson");
            lst.Add("Garcia");
            lst.Add("Martinez");
            lst.Add("Robinson");
            lst.Add("Clark");
            lst.Add("Rodriguez");
            lst.Add("Lewis");
            lst.Add("Lee");
            lst.Add("Walker");
            lst.Add("Hall");
            lst.Add("Allen");
            lst.Add("Young");
            lst.Add("Hernandez");
            lst.Add("King");
            lst.Add("Wright");
            lst.Add("Lopez");
            lst.Add("Hill");
            lst.Add("Scott");
            lst.Add("Green");
            lst.Add("Adams");
            lst.Add("Baker");
            lst.Add("Gonzalez");
            lst.Add("Nelson");
            lst.Add("Carter");
            lst.Add("Mitchell");
            lst.Add("Perez");
            lst.Add("Roberts");
            lst.Add("Turner");
            lst.Add("Phillips");
            lst.Add("Campbell");
            lst.Add("Parker");
            lst.Add("Evans");
            lst.Add("Edwards");
            lst.Add("Collins");
            lst.Add("Stewart");
            lst.Add("Sanchez");
            lst.Add("Morris");
            lst.Add("Rogers");
            lst.Add("Reed");
            lst.Add("Cook");
            lst.Add("Morgan");
            lst.Add("Bell");
            lst.Add("Murphy");
            lst.Add("Bailey");
            lst.Add("Rivera");
            lst.Add("Cooper");
            lst.Add("Richardson");
            lst.Add("Cox");
            lst.Add("Howard");
            lst.Add("Ward");
            lst.Add("Torres");
            lst.Add("Peterson");
            lst.Add("Gray");
            lst.Add("Ramirez");
            lst.Add("James");
            lst.Add("Watson");
            lst.Add("Brooks");
            lst.Add("Kelly");
            lst.Add("Sanders");
            lst.Add("Price");
            lst.Add("Bennett");
            lst.Add("Wood");
            lst.Add("Barnes");
            lst.Add("Ross");
            lst.Add("Henderson");
            lst.Add("Coleman");
            lst.Add("Jenkins");
            lst.Add("Perry");
            lst.Add("Powell");
            lst.Add("Long");
            lst.Add("Patterson");
            lst.Add("Hughes");
            lst.Add("Flores");
            lst.Add("Washington");
            lst.Add("Butler");
            lst.Add("Simmons");
            lst.Add("Foster");
            lst.Add("Gonzales");
            lst.Add("Bryant");
            lst.Add("Alexander");
            lst.Add("Russell");
            lst.Add("Griffin");
            lst.Add("Diaz");
            lst.Add("Hayes");

            str = lst.OrderBy(xx => rnd.Next()).First();
            return str;
        }

        public static string GetFirstName()
        {
            var lst = new List<string>();
            string str = string.Empty;
            lst.Add("Aiden");
            lst.Add("Jackson");
            lst.Add("Mason");
            lst.Add("Liam");
            lst.Add("Jacob");
            lst.Add("Jayden");
            lst.Add("Ethan");
            lst.Add("Noah");
            lst.Add("Lucas");
            lst.Add("Logan");
            lst.Add("Caleb");
            lst.Add("Caden");
            lst.Add("Jack");
            lst.Add("Ryan");
            lst.Add("Connor");
            lst.Add("Michael");
            lst.Add("Elijah");
            lst.Add("Brayden");
            lst.Add("Benjamin");
            lst.Add("Nicholas");
            lst.Add("Alexander");
            lst.Add("William");
            lst.Add("Matthew");
            lst.Add("James");
            lst.Add("Landon");
            lst.Add("Nathan");
            lst.Add("Dylan");
            lst.Add("Evan");
            lst.Add("Luke");
            lst.Add("Andrew");
            lst.Add("Gabriel");
            lst.Add("Gavin");
            lst.Add("Joshua");
            lst.Add("Owen");
            lst.Add("Daniel");
            lst.Add("Carter");
            lst.Add("Tyler");
            lst.Add("Cameron");
            lst.Add("Christian");
            lst.Add("Wyatt");
            lst.Add("Henry");
            lst.Add("Eli");
            lst.Add("Joseph");
            lst.Add("Max");
            lst.Add("Isaac");
            lst.Add("Samuel");
            lst.Add("Anthony");
            lst.Add("Grayson");
            lst.Add("Zachary");
            lst.Add("David");
            lst.Add("Christopher");
            lst.Add("John");
            lst.Add("Isaiah");
            lst.Add("Levi");
            lst.Add("Jonathan");
            lst.Add("Oliver");
            lst.Add("Chase");
            lst.Add("Cooper");
            lst.Add("Tristan");
            lst.Add("Colton");
            lst.Add("Austin");
            lst.Add("Colin");
            lst.Add("Charlie");
            lst.Add("Dominic");
            lst.Add("Parker");
            lst.Add("Hunter");
            lst.Add("Thomas");
            lst.Add("Alex");
            lst.Add("Ian");
            lst.Add("Jordan");
            lst.Add("Cole");
            lst.Add("Julian");
            lst.Add("Aaron");
            lst.Add("Carson");
            lst.Add("Miles");
            lst.Add("Blake");
            lst.Add("Brody");
            lst.Add("Adam");
            lst.Add("Sebastian");
            lst.Add("Adrian");
            lst.Add("Nolan");
            lst.Add("Sean");
            lst.Add("Riley");
            lst.Add("Bentley");
            lst.Add("Xavier");
            lst.Add("Hayden");
            lst.Add("Jeremiah");
            lst.Add("Jason");
            lst.Add("Jake");
            lst.Add("Asher");
            lst.Add("Micah");
            lst.Add("Jace");
            lst.Add("Brandon");
            lst.Add("Josiah");
            lst.Add("Hudson");
            lst.Add("Nathaniel");
            lst.Add("Bryson");
            lst.Add("Ryder");
            lst.Add("Justin");
            lst.Add("Bryce");

//—————female

            lst.Add("Sophia");
            lst.Add("Emma");
            lst.Add("Isabella");
            lst.Add("Olivia");
            lst.Add("Ava");
            lst.Add("Lily");
            lst.Add("Chloe");
            lst.Add("Madison");
            lst.Add("Emily");
            lst.Add("Abigail");
            lst.Add("Addison");
            lst.Add("Mia");
            lst.Add("Madelyn");
            lst.Add("Ella");
            lst.Add("Hailey");
            lst.Add("Kaylee");
            lst.Add("Avery");
            lst.Add("Kaitlyn");
            lst.Add("Riley");
            lst.Add("Aubrey");
            lst.Add("Brooklyn");
            lst.Add("Peyton");
            lst.Add("Layla");
            lst.Add("Hannah");
            lst.Add("Charlotte");
            lst.Add("Bella");
            lst.Add("Natalie");
            lst.Add("Sarah");
            lst.Add("Grace");
            lst.Add("Amelia");
            lst.Add("Kylie");
            lst.Add("Arianna");
            lst.Add("Anna");
            lst.Add("Elizabeth");
            lst.Add("Sophie");
            lst.Add("Claire");
            lst.Add("Lila");
            lst.Add("Aaliyah");
            lst.Add("Gabriella");
            lst.Add("Elise");
            lst.Add("Lillian");
            lst.Add("Samantha");
            lst.Add("Makayla");
            lst.Add("Audrey");
            lst.Add("Alyssa");
            lst.Add("Ellie");
            lst.Add("Alexis");
            lst.Add("Isabelle");
            lst.Add("Savannah");
            lst.Add("Evelyn");
            lst.Add("Leah");
            lst.Add("Keira");
            lst.Add("Allison");
            lst.Add("Maya");
            lst.Add("Lucy");
            lst.Add("Sydney");
            lst.Add("Taylor");
            lst.Add("Molly");
            lst.Add("Lauren");
            lst.Add("Harper");
            lst.Add("Scarlett");
            lst.Add("Brianna");
            lst.Add("Victoria");
            lst.Add("Liliana");
            lst.Add("Aria");
            lst.Add("Kayla");
            lst.Add("Annabelle");
            lst.Add("Gianna");
            lst.Add("Kennedy");
            lst.Add("Stella");
            lst.Add("Reagan");
            lst.Add("Julia");
            lst.Add("Bailey");
            lst.Add("Alexandra");
            lst.Add("Jordyn");
            lst.Add("Nora");
            lst.Add("Carolin");
            lst.Add("Mackenzie");
            lst.Add("Jasmine");
            lst.Add("Jocelyn");
            lst.Add("Kendall");
            lst.Add("Morgan");
            lst.Add("Nevaeh");
            lst.Add("Maria");
            lst.Add("Eva");
            lst.Add("Juliana");
            lst.Add("Abby");
            lst.Add("Alexa");
            lst.Add("Summer");
            lst.Add("Brooke");
            lst.Add("Penelope");
            lst.Add("Violet");
            lst.Add("Kate");
            lst.Add("Hadley");
            lst.Add("Ashlyn");
            lst.Add("Sadie");
            lst.Add("Paige");
            lst.Add("Katherine");
            lst.Add("Sienna");
            lst.Add("Piper");

            str = lst.OrderBy(xx => rnd.Next()).First();
            return str;
        }
    }
}