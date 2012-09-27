﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFC.Domain
{
    public class SMS
    {
        public static Dictionary<string, string> Carriers()
        {
            return new Dictionary<string, string>
                       {
                           {"3 River Wireless", "@number@sms.3rivers.net"},
                           {"ACS Wireless", "@number@paging.acswireless.com"},
                           {"Advantage Communications", "@number@advantagepaging.com"},
                           {"Airtel Wireless (Montana, USA)", "@number@sms.airtelmontana.com"},
                           {"AirVoice", "@number@mmode.com"},
                           {"Airtouch Pagers", "@number@airtouch.net"},                          
                           {"Alaska Communications Systems", "@number@msg.acsalaska.com"},
                           {"AllTel", "@number@message.alltel.com"},
                           {"Alltel PCS", "@number@message.alltel.com"},
                           {"AlphNow", "@number@alphanow.net"},
                           {"American Messaging (SBC/Ameritech)", "@number@page.americanmessaging.net"},
                           {"Ameritech Clearpath", "@number@clearpath.acswireless.com"},
                           {"Ameritech Paging", "@number@pageapi.com"},
                           {"Aql", "@number@text.aql.com"},
                           {"Arch Pagers (PageNet)", "@number@archwireless.net"},
                           {"AT&T", "@number@txt.att.net"},
                           {"AT&T Free2Go", "@number@mmode.com"},
                           {"AT&T PCS", "@numberx@mobile.att.net"},
                           {"AT&T Pocketnet PCS", "@numberx@dpcs.mobile.att.net"},
                           {"Beepwear", "@numberx@beepwear.net"},
                           {"Bell Atlantic", "@numberx@message.bam.com"},
                           {"Bell South (Blackberry)", "@number@bellsouthtips.com"},
                           {"Bell South Mobility", "@number@blsdcs.net"},
                           {"Bell South", "@number@sms.bellsouth.com"},
                           {"Bluegrass Cellular", "@number@sms.bluecell.com"},
                           {"Boost Mobile", "@number@myboostmobile.com"},
                           {"CallPlus", "@number@mmode.com"},
                           {"Carolina Mobile Communications", "@number@cmcpaging.com"},
                           {"Carolina West Wireless", "@numberx@cwwsms.com"},
                           {"Cellular One MMS", "@numberx@mms.uscc.net"},
                           {"Cellular One East Coast", "@number@phone.cellone.net"},
                           {"Cellular One PCS", "@number@paging.cellone-sf.com"},
                           {"Cellular One South West", "@number@swmsg.com"},
                           {"Cellular One West", "@number@mycellone.com"},
                           {"Cellular One", "@numberx@cellularone.txtmsg.com"},
                           {"Cellular South", "@number@csouth1.com"},
                           {"Centennial Wireless", "@numberx@cwemail.com"},
                           {"Central Vermont Communications", "@number@cvcpaging.com"},
                           {"CenturyTel", "@number@messaging.centurytel.net"},
                           {"Cincinnati Bell Wireless", "@numberx@gocbw.com"},
                           {"Cingular", "@numberx@mycingular.com"},
                           {"Cingular (GSM)", "@number@cingularme.com"},
                           {"Cingular (TDMA)", "@number@mmode.com"},
                           {"Cingular Wireless", "@number@mobile.mycingular.net"},
                           {"Comcast", "@numberx@comcastpcs.textmsg.com"},
                           {"Communication Specialists", "@numberx@pager.comspeco.com"},
                           {"Cook Paging", "@number@cookmail.com"},
                           {"Corr Wireless Communications", "@number@corrwireless.net"},
                           {"Cricket", "@numberx@sms.mycricket.com"},
                           {"Digi-Page / Page Kansas", "@numberx@page.hit.net"},
                           {"Dobson Communications Corporation", "@number@mobile.dobson.net"},
                           {"Dobson-Alex Wireless / Dobson-Cellular One", "@number@mobile.cellularone.com"},
                           {"Edge Wireless", "@number@sms.edgewireless.com"},
                           {"Gabriel Wireless", "@numberx@epage.gabrielwireless.com"},
                           {"Galaxy Corporation", "@number@sendabeep.net"},
                           {"GCS Paging", "@number@webpager.us"},
                           {"General Communications Inc. (Alaska)", "@numberx@msg.gci.net"},
                           {"Globalstar (satellite)", "@numberx@msg.globalstarusa.com"},
                           {"GrayLink / Porta-Phone", "@number@epage.porta-phone.com"},
                           {"GTE", "@number@gte.pagegate.net"},
                           {"Helio", "@numberx@messaging.sprintpcs.com"},
                           {"Houston Cellular", "@number@text.houstoncellular.net"},
                           {"Illinois Valley Cellular", "@numberx@ivctext.com"},
                           {"Infopage Systems", "@numberx@page.infopagesystems.com"},
                           {"Inland Cellular Telephone", "@number@inlandlink.com"},
                           {"Iridium (satellite)", "@numberx@msg.iridium.com"},
                           {"i wireless", "@numberx.iws@iwspcs.net"},
                           {"JSM Tele-Page", "@number@jsmtel.com"},
                           {"Lauttamus Communication", "@number@e-page.net"},
                           {"MCI Phone", "@number@mci.com"},
                           {"Metro PCS", "@number@metropcs.sms.us"},
                           {"Metrocall 2-way", "@number@my2way.com"},
                           {"Metrocall", "@number@page.metrocall.com"},
                           {"Midwest Wireless", "@number@clearlydigital.com"},
                           {"Mobilecom PA", "@number@page.mobilcom.net"},
                           {"Mobilfone", "@number@page.mobilfone.com"},
                           {"MobiPCS (Hawaii only)", "@numberx@mobipcs.net"},
                           {"Motient", "@isp.com"},
                           {"Morris Wireless", "@number@beepone.net"},
                           {"Northeast Paging", "@numberx@pager.ucom.com"},
                           {"Nextel", "@number@messaging.nextel.com"},
                           {"NPI Wireless", "@number@npiwireless.com"},
                           {"Ntelos", "@number@pcs.ntelos.com"},
                           {"O2", "@numberx@mobile.celloneusa.com"},
                           {"Omnipoint", "@number@omnipoint.com"},
                           {"OnlineBeep", "@number@onlinebeep.net"},
                           {"PCS One", "@number@pcsone.net"},
                           {"Pacific Bell", "@number@pacbellpcs.net"},
                           {"PageMart Advanced /2way", "@numberx@airmessage.net"},
                           {"PageMart", "@number@pagemart.net"},
                           {"PageOne NorthWest", "@number@page1nw.com"},
                           {"Pioneer / Enid Cellular", "@number@msg.pioneerenidcellular.com"},
                           {"Price Communications", "@number@mobilecell1se.com"},
                           {"Primeco", "@numberx@email.uscc.net"},
                           {"ProPage", "@number@page.propage.net"},
                           {"Public Service Cellular", "@number@sms.pscel.com"},
                           {"Qualcomm", "name@pager.qualcomm.com"},
                           {"Qwest", "@number@qwestmp.com"},
                           {"RAM Page", "@number@ram-page.com"},
                           {"SBC Ameritech Paging (see also American Messaging)", "@numberx@paging.acswireless.com"},
                           {"ST Paging", "pin@page.stpaging.com"},
                           {"Safaricom", "@number@safaricomsms.com"},
                           {"Satelindo GSM", "@number@satelindogsm.com"},
                           {"Satellink", "@number.pageme@satellink.net"},
                           {"Simple Freedom", "@number@text.simplefreedom.net"},
                           {"Skytel Pagers", "@number@email.skytel.com"},
                           {"Smart Telecom", "@number@mysmart.mymobile.ph"},
                           {"Southern LINC", "@number@page.southernlinc.com"},
                           {"Southwestern Bell", "@number@email.swbw.com"},
                           {"Sprint PCS", "@number@messaging.sprintpcs.com"},
                           {"Sprint", "@number@sprintpaging.com"},
                           {"SunCom", "@number@tms.suncom.com"},
                           {"Surewest Communications", "@number@mobile.surewest.com"},
                           {"T-Mobile", "@number@tmomail.net"},
                           {"TIM", "@number@timnet.com"},
                           {"TSR Wireless", "@number@alphame.com"},
                           {"Teleflip", "@numberx@teleflip.com"},
                           {"Teletouch", "@number@pageme.teletouch.com"},
                           {"Telus", "@number@msg.telus.com"},
                           {"The Indiana Paging Co", "xxxx@pager.tdspager.com"},
                           {"Thumb Cellular", "@numberx@sms.thumbcellular.com"},
                           {"Tracfone", "@numberx@txt.att.net"},
                           {"Triton", "@number@tms.suncom.com"},
                           {"UCOM", "@numberx@pager.ucom.com"},
                           {"US Cellular", "@numberx@smtp.uscc.net"},
                           {"US West", "@numberx@uswestdatamail.com"},
                           {"USA Mobility", "@number@mobilecomm.net"},
                           {"Unicel", "@number@utext.com"},
                           {"Verizon PCS", "@number@myvzw.com"},
                           {"Verizon Pagers", "@number@myairmail.com"},
                           {"Verizon", "@number@vtext.com"},
                           {"Virgin Mobile", "@number@vxtras.com"},
                           {"WebLink Wireless", "@number@pagemart.net"},
                           {"West Central Wireless", "@number@sms.wcc.net"},
                           {"Western Wireless", "@number@cellularonewest.com"},
                           {"Wyndtell", "@number@wyndtell.com"},
                           {"None","None"}

                       };

        }

    }

}