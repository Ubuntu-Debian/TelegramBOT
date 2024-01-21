/*
 Copyright (c) 2023-24, the Phantom Inker.  All rights reserved.
   Redistribution and use in source and binary forms, with or without
   modification, are permitted provided that the following conditions are
   met:
   
       (1) Redistributions of source code must retain the above copyright
       notice, this list of conditions and the following disclaimer. 
   
       (2) Redistributions in binary form must reproduce the above copyright
       notice, this list of conditions and the following disclaimer in
       the documentation and/or other materials provided with the
       distribution.  
       
       (3)The name of the author may not be used to
       endorse or promote products derived from this software without
       specific prior written permission.
   
   THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR
   IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
   WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
   DISCLAIMED. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT,
   INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
   (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
   SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
   HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
   STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING
   IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
   POSSIBILITY OF SUCH DAMAGE.
 */
using Microsoft.Data.Sqlite;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Mime;
using Telegram.Bot.Requests;
using Telegram.Bot.Types.ReplyMarkups;
using File = Telegram.Bot.Types.File;
using Telegram.Bot.Types.ReplyMarkups;
using System.Timers;
using System.Globalization;
using System.Reflection.Metadata;
using Newtonsoft.Json;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Int64 = System.Int64;

namespace programm
{
    class Program
    {

        private static string put = "/media/lambda/Projects/C#/TelegramBOT_V2.12_I_LOVE_BSD/TelegramBOT_V2.12_I_LOVE_BSD";
        //private static string put = "/home/pc-server/TelegramBOT_V2.12_I_LOVE_BSD";



        private static string math = "<b>Математика : </b>";
        private static string obshetvo = "<b>Обществознание :</b>";
        private static string odnknr = "<b>ОДНКНР : </b>";
        private static string englis_e_v = "<b>Английский язык(Яна Вячеславовна) : </b>";
        private static string russian = "<b>Русский язык : </b>";
        private static string english_s_v = "<b>Английский язык(Светлана Владимировна) :</b>";
        private static string geography = "<b>География : </b>";
        private static string biology = "<b>Биология : </b>";
        private static string literatur = "<b>Литература : </b>";
        private static string history = "<b>История : </b>";

        private static string texnology = "<b>Технология : </b>";

        private static string music = "<b> Музыка : </b>";

        //private static long[] admins = new long[] {6508845207,1342735394};
        //private static long[] texnology_man = new long[] {};
        private static string dnevnik = "";
        private static string otpr_bufer = "";


        static void Main(string[] args)
        {

            var botClient = new TelegramBotClient(Config.TelegramApiKey);
            using CancellationTokenSource cts = new();
            ReceiverOptions receiverOptions = new()
            {
                AllowedUpdates = Array.Empty<UpdateType>()
            };

            botClient.StartReceiving(Update, Error);


            Console.ReadLine();

        }

        private static async Task Update(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            switch (update.Type)
                        {
                            case Telegram.Bot.Types.Enums.UpdateType.CallbackQuery:
                                var message_callback_query = update.CallbackQuery.Message;
                                string message_data = update.CallbackQuery.Data;
                                switch (message_data)
                                {
                                    case "math":
                                        dnevnik = "math";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "obshetvo":
                                        dnevnik = "obshetvo";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "odnknr":
                                        dnevnik = "odnknr";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "englis_e_v":
                                        dnevnik = "englis_e_v";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "russian":
                                        dnevnik = "russian";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "english_s_v":
                                        dnevnik = "english_s_v";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "geography":
                                        dnevnik = "geography";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "biology":
                                        dnevnik = "biology";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "literatur":
                                        dnevnik = "literatur";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "history":
                                        dnevnik = "history";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "texnology":
                                        dnevnik = "texnology";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "music":
                                        dnevnik = "music";
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id,"Напиши ДЗ : ");
                                        break;
                                    case "dl_vseDDDD":
                                        sql_remove_data(message_callback_query.Chat.Id, "data_users", "id", data_users);
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id, "Удалил !",
                                            parseMode: ParseMode.Html);
                                        break;
                                    case "no":
                                        if (storage_knopka.ContainsKey(message_callback_query.Chat.Id))
                                        {
                                            storage_knopka.Remove(message_callback_query.Chat.Id);
                                        }
                                        await botClient.SendTextMessageAsync(message_callback_query.Chat.Id, "Можеш не писать  !",
                                            parseMode: ParseMode.Html);
                                        break;
                                    default:
                                        if (update.CallbackQuery.Data.ToLower().Contains("dl"))
                                        {
                                            string[] dl =
                                                update.CallbackQuery.Data.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                            sql_remove_data(long.Parse(dl[1]), "data_users", "id_sql", data_users);
                                            await botClient.SendTextMessageAsync(message_callback_query.Chat.Id, "Удалил !",
                                                parseMode: ParseMode.Html);
                                        }

                                        break;
                                }

                                break;

                            case Telegram.Bot.Types.Enums.UpdateType.Message:
                                if (update.Message.ToString().Length > 4000)
                                {
                                    await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Слишком длинное сообщение",
                                        parseMode: ParseMode.Html);
                                    break;
                                }
                                
                                    
                                
                                var message = update.Message;
                                
                                sql_command($@"INSERT INTO log (id,log) VALUES({message.Chat.Id},'{message.Text}');", data_users);

                                sql_command($@"INSERT INTO people (id, male) VALUES({message.Chat.Id},'{message.Chat.FirstName}');",
                                    data_users);
                                List<Int64> del_user = new List<Int64>();

                                async Task sql_users(string chto, string otkuda, Int64 schem, string data_users)
                                {

                                    using (var connection = new SqliteConnection(data_users))
                                    {
                                        connection.Open();

                                        var selectCmd = connection.CreateCommand();
                                        selectCmd.CommandText = @"SELECT " + chto + @" FROM " + otkuda + @" WHERE id  = " +
                                                                schem;

                                        using (var reader = selectCmd.ExecuteReader())
                                        {
                                            int i = 0;

                                            while (reader.Read())
                                            {

                                                i++;
                                                if (i > 1)
                                                {
                                                    del_user.Add(reader.GetInt64(0));
                                                    //sql_remove_data(reader.GetInt64(0),"people","id_sql",data_users);
                                                }


                                            }



                                        }
                                    }


                                }

                                sql_users("*", "people", message.Chat.Id, data_users);
                                foreach (var VARIABLE in del_user)
                                {
                                    sql_remove_data(VARIABLE, "people", "id_sql", data_users);
                                }

                                del_user = new List<long>();



                                //sql_remove_data(message.Chat.Id, "people", "id", data_users);
                                //sql_command($@"INSERT INTO people (id, male) VALUES({message.Chat.Id},'{message.Chat.FirstName}');",
                                //    data_users);

                                switch (message.Text.ToLower())
                                {
                                    case "/start":
                                        if (message.Chat.Id == 6508845207)
                                        {

                                            await botClient.SendTextMessageAsync(message.Chat.Id, "<b>Ты -</b> человек ",
                                                parseMode: ParseMode.Html,replyMarkup: replyKeyboardMarkup_Kirill);
                                            

                                            






                                            //QRCodeWriter.CreateQrCode("hello world", 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng("MyQR.png");

                                            //InputFileStream qr = new InputFileStream(content: System.IO.File.OpenRead("MyQR.png"));
                                            //await botClient.SendPhotoAsync(message.Chat.Id, (InputOnlineFile)qr);
                                        }
                                        else
                                        {
                                            if (texnology_mans(message.Chat.Id))
                                            {
                                                await botClient.SendTextMessageAsync(message.Chat.Id, "<b>Ты -</b>  TexnologyMAN",
                                                    parseMode: ParseMode.Html, replyMarkup:  Program.replyKeyboardMarkup);
                                            }


                                            if (admins(message.Chat.Id))
                                            {
                                                await botClient.SendTextMessageAsync(message.Chat.Id, "<b>Ты -</b>  Admin",
                                                    parseMode: ParseMode.Html, replyMarkup:  Program.replyKeyboardMarkup);
                                            }
                                            await botClient.SendTextMessageAsync(message.Chat.Id, "<b>Ты -</b>  не Кирилл",
                                                parseMode: ParseMode.Html, replyMarkup:  Program.replyKeyboardMarkup);

                                        }

                                        break;
                                    case "написть технологию":
                                        dnevnik = "texnology";
                                        await botClient.SendTextMessageAsync(message.Chat.Id,
                                            "<b>Напишите ДЗ : </b>", parseMode: ParseMode.Html,
                                            replyMarkup: replyKeyboardMarkup_Kirill);
                                        break;
                                    case "записать в хранилеще":
                                        await botClient.SendTextMessageAsync(message.Chat.Id, "Отправте текст :",
                                            parseMode: ParseMode.Html,replyMarkup: inlainknopka("❌ Хватит ❌","no"));
                                        if (storage_knopka.ContainsKey(message.Chat.Id) == false)
                                        {
                                            storage_knopka.Add(message.Chat.Id, "stor");
                                        }
                                            else
                                        {
                                            storage_knopka[message.Chat.Id] = "stor";
                                        }


                                        break;
                                    case "электронный дневник":


                                        /*ScriptEngine engine_dv = Python.CreateEngine();
                                        ScriptScope scope_dv = engine_dv.CreateScope();
                                        engine_dv.ExecuteFile($"{put}/dnevnik.py", scope_dv);
                                        dynamic raspisanie = scope_dv.GetVariable("message");
                                        dynamic result = raspisanie((int)System.DateTime.Now.DayOfWeek + 1);
                                        string str_result = result.ToString();


                                        switch (message.Chat.Id)
                                        {
                                            case 6508845207:
                                                await botClient.SendTextMessageAsync(message.Chat.Id, str_result, parseMode: ParseMode.Html,replyMarkup:dnevnik______1);
                                                break;
                                            case 1342735394:
                                                await botClient.SendTextMessageAsync(message.Chat.Id, str_result, parseMode: ParseMode.Html,replyMarkup:dnevnik______1);
                                                break;


                                        }*/


                                        async Task sql_dnevnik_math()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "math";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{math}{text}\n";
                                                    }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_obshetvo()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "obshetvo";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{obshetvo}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_odnknr()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "odnknr";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{odnknr}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_englis_e_v()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "englis_e_v";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{englis_e_v}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_russian()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "russian";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{russian}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_english_s_v()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "english_s_v";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{english_s_v}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_geography()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "geography";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{geography}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_biology()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "biology";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{biology}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_literatur()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "literatur";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{literatur}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_history()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "history";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{history}{text}\n";


                                                    }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_texnology()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "texnology";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{texnology}{text}\n";


                                                    }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_music()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "music";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{music}{text}\n";


                                                    }
                                                }

                                            }
                                        }

                                        sql_dnevnik_math();
                                        sql_dnevnik_obshetvo();
                                        sql_dnevnik_odnknr();
                                        sql_dnevnik_englis_e_v();
                                        sql_dnevnik_english_s_v();
                                        sql_dnevnik_russian();
                                        sql_dnevnik_geography();
                                        sql_dnevnik_biology();
                                        sql_dnevnik_literatur();
                                        sql_dnevnik_history();
                                        sql_dnevnik_texnology();
                                        sql_dnevnik_music();
                                        bool texn = texnology_mans(message.Chat.Id);

                                        switch (message.Chat.Id)
                                        {
                                            case 6508845207:
                                                await botClient.SendTextMessageAsync(message.Chat.Id, otpr_bufer ,parseMode: ParseMode.Html,replyMarkup: dnevnik______1);

                                                break;
                                            case 1342735394:
                                                await botClient.SendTextMessageAsync(message.Chat.Id, otpr_bufer ,parseMode: ParseMode.Html,replyMarkup: dnevnik______1);
                                                break;
                                            default:
                                                if (texn)
                                                {
                                                    await botClient.SendTextMessageAsync(message.Chat.Id, otpr_bufer ,parseMode: ParseMode.Html,replyMarkup: replyKeyboardMarkup_Texnology);
                                                }
                                                else
                                                {
                                                    await botClient.SendTextMessageAsync(message.Chat.Id, otpr_bufer ,parseMode: ParseMode.Html);
                                                }

                                                break;
                                        }


            			    otpr_bufer = "";



                                        break;
                                    case "опубликовать":
                                        if (admins(message.Chat.Id))
                                        {
                                            sql_dnevnik_math();
                                            sql_dnevnik_obshetvo();
                                            sql_dnevnik_odnknr();
                                            sql_dnevnik_englis_e_v();
                                            sql_dnevnik_english_s_v();
                                            sql_dnevnik_russian();
                                            sql_dnevnik_geography();
                                            sql_dnevnik_biology();
                                            sql_dnevnik_literatur();
                                            sql_dnevnik_history();
                                            sql_dnevnik_texnology();
                                            sql_dnevnik_music();
                                            await botClient.SendTextMessageAsync(-1001956303494,otpr_bufer, parseMode: ParseMode.Html,disableWebPagePreview: true);


                                            otpr_bufer = "";
                                            string f = da();
                                            await botClient.SendTextMessageAsync(-1001956303494,f, parseMode: ParseMode.Html,disableWebPagePreview: true);

                                            await botClient.SendTextMessageAsync(message.Chat.Id,"<b>Готово !</b>", parseMode: ParseMode.Html);

                                        }


                                        break;
                                    case "написть дз":
                                        switch (message.Chat.Id)
                                        {
                                            case 6508845207:
                                                await botClient.SendTextMessageAsync(message.Chat.Id, "Выбирите урок :",
                                                    parseMode: ParseMode.Html,replyMarkup: vbor());


                                                break;
                                            case 1342735394:

                                                await botClient.SendTextMessageAsync(message.Chat.Id, "Выбирите урок :",
                                                    parseMode: ParseMode.Html,replyMarkup: vbor());

                                                break;
                                            case 1350668423:

                                                await botClient.SendTextMessageAsync(message.Chat.Id, "Выбирите урок :",
                                                    parseMode: ParseMode.Html,replyMarkup: vbor());

                                                break;
                                            case 2098760711:

                                                await botClient.SendTextMessageAsync(message.Chat.Id, "Выбирите урок :",
                                                    parseMode: ParseMode.Html,replyMarkup: vbor());

                                                break;
                                        }


                                        break;

                                    case "хранилище":
                                        bool delete_bool = true;

                                        async Task sql_data_stor(string chto, string otkuda, Int64 schem, string data_users)
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();

                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + chto + @" FROM " + otkuda + @" WHERE id  = " +
                                                                        schem;

                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {

                                                        delete_bool = false;
                                                        var text = reader.GetString(2);
                                                        var id = reader.GetInt64(0);
                                                        await botClient.SendTextMessageAsync(message.Chat.Id, text,
                                                            parseMode: ParseMode.Html,
                                                            replyMarkup: inlainknopka("❌ Удалить ❌", "dl " + id));

                                                        //return text;


                                                    }

                                                    if (delete_bool == false)
                                                    {
                                                        await botClient.SendTextMessageAsync(message.Chat.Id, "Удалить всё ?",
                                                            parseMode: ParseMode.Html,
                                                            replyMarkup: inlainknopka("❌ Удалить ❌", "dl_vseDDDD"));

                                                    }

                                                }
                                            }


                                        }

                                        sql_data_stor("*", "data_users", message.Chat.Id, data_users);

                                        if (delete_bool)
                                        {
                                            await botClient.SendTextMessageAsync(message.Chat.Id, "Ничего нет !",
                                                parseMode: ParseMode.Html);
                                        }


                                        break;
                                    case "список людей":

                                        if (message.Chat.Id == 6508845207)
                                        {
                                            bool deletee_bool = true;

                                            async Task sql_people(string chto, string otkuda, string data_users)
                                            {

                                                using (var connection = new SqliteConnection(data_users))
                                                {
                                                    connection.Open();

                                                    var selectCmd = connection.CreateCommand();
                                                    selectCmd.CommandText = @"SELECT " + chto + @" FROM " + otkuda;

                                                    using (var reader = selectCmd.ExecuteReader())
                                                    {
                                                        while (reader.Read())
                                                        {

                                                            deletee_bool = false;
                                                            var text = reader.GetString(2);
                                                            var id = reader.GetInt64(1);
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "ID : " + id + " Name : " + text,
                                                                parseMode: ParseMode.Html);



                                                        }


                                                    }
                                                }


                                            }

                                            sql_people("*", "people", data_users);

                                            if (deletee_bool)
                                            {
                                                await botClient.SendTextMessageAsync(message.Chat.Id, "Ничего нет !",
                                                    parseMode: ParseMode.Html);
                                            }
                                        }

                                        break;


                                    case "нод и нок":
                                        await botClient.SendTextMessageAsync(message.Chat.Id, "Отправьте 2 цифры через пробел  :",
                                            parseMode: ParseMode.Html,replyMarkup: inlainknopka("❌ Хватит ❌","no"));
                                        if (storage_knopka.ContainsKey(message.Chat.Id) == false)
                                        {
                                            storage_knopka.Add(message.Chat.Id, "gcd");
                                        }
                                        else
                                        {
                                            storage_knopka[message.Chat.Id] = "gcd";
                                        }
                                        break;
                                    case "калькулятор дробей":
                                        await botClient.SendTextMessageAsync(message.Chat.Id, "Отправьте 2 дроби через - '.' через пробел  :",
                                            parseMode: ParseMode.Html,replyMarkup: inlainknopka("❌ Хватит ❌","no"));
                                        if (storage_knopka.ContainsKey(message.Chat.Id) == false)
                                        {
                                            storage_knopka.Add(message.Chat.Id, "calc");
                                        }
                                        else
                                        {
                                            storage_knopka[message.Chat.Id] = "calc";
                                        }
                                        break;

                                    default:
                                        if (storage_knopka.ContainsKey(message.Chat.Id))
                                        {
                                            switch (storage_knopka[message.Chat.Id])
                                            {
                                                case "stor":
                                                    sql_command(
                                                        $"INSERT INTO data_users (id, data) VALUES({message.Chat.Id},'{message.Text}');",
                                                        data_users);
                                                    await botClient.SendTextMessageAsync(message.Chat.Id, "Запомнил !",
                                                        parseMode: ParseMode.Html);


                                                    if (storage_knopka.ContainsKey(message.Chat.Id))
                                                    {
                                                        storage_knopka.Remove(message.Chat.Id);
                                                    }
                                                    break;
                                                case "gcd":
                                                    string[] bufernk = message.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                                if (bufernk.Length != 2)
                                                {
                                                    if (message.Chat.Id == 6508845207)
                                                    {
                                                        await botClient.SendTextMessageAsync(message.Chat.Id,
                                                            "<b>В команде всего 2-а параметра !</b>", parseMode: ParseMode.Html,
                                                            replyMarkup: replyKeyboardMarkup_Kirill);
                                                    }
                                                    else
                                                    {
                                                        await botClient.SendTextMessageAsync(message.Chat.Id,
                                                            "<b>В команде всего 2-а параметра !</b>", parseMode: ParseMode.Html,
                                                            replyMarkup: replyKeyboardMarkup);
                                                    }

                                                }
                                                else
                                                {
                                                    int nod1;
                                                    int nod2;
                                                    bool buft1 = int.TryParse(bufernk[0], out nod1) == false;
                                                    bool buft2 = int.TryParse(bufernk[1], out nod2) == false;
                                                    if (buft1)
                                                    {
                                                        if (message.Chat.Id == 6508845207)
                                                        {
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "<b>Должны быть числа!</b>", parseMode: ParseMode.Html,
                                                                replyMarkup: replyKeyboardMarkup_Kirill);
                                                        }
                                                        else
                                                        {
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "<b>Должны быть числа !</b>", parseMode: ParseMode.Html,
                                                                replyMarkup: replyKeyboardMarkup);
                                                        }

                                                    }
                                                    else
                                                    {
                                                        if (buft2)
                                                        {
                                                            if (message.Chat.Id == 6508845207)
                                                            {
                                                                await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                    "<b>Должны быть числа!</b>", parseMode: ParseMode.Html,
                                                                    replyMarkup: replyKeyboardMarkup_Kirill);
                                                            }
                                                            else
                                                            {
                                                                await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                    "<b>Должны быть числа !</b>", parseMode: ParseMode.Html,
                                                                    replyMarkup: replyKeyboardMarkup);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            ScriptEngine engine = Python.CreateEngine();
                                                            ScriptScope scope = engine.CreateScope();

                                                            engine.ExecuteFile(
                                                                $"{put}/gcd_lcm.py",
                                                                scope);
                                                            dynamic gcd = scope.GetVariable("gcd");
                                                            dynamic lcm = scope.GetVariable("lcm");
                                                            dynamic gcd_r = gcd(nod1, nod2);
                                                            dynamic lcm_r = lcm(nod1, nod2);
                                                            string g = gcd_r.ToString();
                                                            string l = lcm_r.ToString();
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "<b>НОД : </b>" + g, parseMode: ParseMode.Html);
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "<b>НОК : </b>" + l, parseMode: ParseMode.Html);

                                                            if (storage_knopka.ContainsKey(message.Chat.Id))
                                                            {
                                                                storage_knopka.Remove(message.Chat.Id);
                                                            }
                                                        }











                                                    }


                                                }

                                                    break;

                                                case "calc":
                                                    string[] bufer = message.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                                    if (bufer.Length != 2)
                                                    {
                                                        if (message.Chat.Id == 6508845207)
                                                        {
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "<b>В команде всего 2-а параметра !</b>", parseMode: ParseMode.Html,
                                                                replyMarkup: replyKeyboardMarkup_Kirill);
                                                        }
                                                        else
                                                        {
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "<b>В команде всего 2-а параметра !</b>", parseMode: ParseMode.Html,
                                                                replyMarkup: replyKeyboardMarkup);
                                                        }

                                                    }
                                                    else
                                                    {
                                                        ScriptEngine engin = Python.CreateEngine();
                                                        ScriptScope scop = engin.CreateScope();

                                                        engin.ExecuteFile($"{put}/calc.py", scop);
                                                        dynamic flo = scop.GetVariable("flo");
                                                        dynamic ls = flo(bufer[0],bufer[1]);
                                                        foreach (var VARIABLE in ls)
                                                        {
                                                            string v = VARIABLE.ToString();
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                v, parseMode: ParseMode.Html);

                                                        }
                                                    }
            					                    if (storage_knopka.ContainsKey(message.Chat.Id))
                                                    {
                                                        storage_knopka.Remove(message.Chat.Id);
                                                    }

                                                    break;
                                            }


                                        }
                                        else
                                        {
                                            if (dnevnik != "")
                                            {
                                                if (message.Chat.Id == 6508845207)
                                                {
                                                    sql_command($"UPDATE {dnevnik} SET TEXT = '{message.Text} (ДЗ Писал : Кирилл | Староста) от {DateTime.Today.ToString().Replace("/",".")[..10]}' WHERE id = 1;",
                                                        data_users);
                                                    if (message.Chat.Id == 6508845207)
                                                    {
                                                        await botClient.SendTextMessageAsync(message.Chat.Id,
                                                            "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                            replyMarkup: replyKeyboardMarkup_Kirill);
                                                    }
                                                    else
                                                    {
                                                        await botClient.SendTextMessageAsync(message.Chat.Id,
                                                            "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                            replyMarkup: replyKeyboardMarkup);
                                                    }

                                                    dnevnik = "";
                                                }
                                                else
                                                {
                                                    if (message.Chat.Id == 1342735394)
                                                    {
                                                        sql_command($"UPDATE {dnevnik} SET TEXT = '{message.Text} (ДЗ Писал : Андрей | ЗАМ от {DateTime.Today.ToString().Replace("/",".")[..10]})' WHERE id = 1;",
                                                            data_users);
                                                        if (message.Chat.Id == 6508845207)
                                                        {
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                                replyMarkup: replyKeyboardMarkup_Kirill);
                                                        }
                                                        else
                                                        {
                                                            await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                                replyMarkup: replyKeyboardMarkup);
                                                        }

                                                        dnevnik = "";
                                                        
                                                    }
                                                    else
                                                    {
                                                        if (message.Chat.Id == 1350668423)
                                                        {
                                                            sql_command($"UPDATE {dnevnik} SET TEXT = '{message.Text} (ДЗ Писал : Макар от {DateTime.Today.ToString().Replace("/",".")[..10]})' WHERE id = 1;",
                                                                data_users);
                                                            if (message.Chat.Id == 6508845207)
                                                            {
                                                                await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                    "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                                    replyMarkup: replyKeyboardMarkup_Kirill);
                                                            }
                                                            else
                                                            {
                                                                await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                    "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                                    replyMarkup: replyKeyboardMarkup);
                                                            }

                                                            dnevnik = "";
                                                        
                                                        }
                                                        else
                                                        {
                                                            if (message.Chat.Id == 2098760711)
                                                            {
                                                                sql_command($"UPDATE {dnevnik} SET TEXT = '{message.Text} (ДЗ Писал : Влад от {DateTime.Today.ToString().Replace("/",".")[..10]})' WHERE id = 1;",
                                                                    data_users);
                                                                if (message.Chat.Id == 6508845207)
                                                                {
                                                                    await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                        "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                                        replyMarkup: replyKeyboardMarkup_Kirill);
                                                                }
                                                                else
                                                                {
                                                                    await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                        "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                                        replyMarkup: replyKeyboardMarkup);
                                                                }

                                                                dnevnik = "";
                                                        
                                                            }
                                                            else
                                                            {
                                                                bool texnn = texnology_mans(message.Chat.Id);


                                                                if (texnn)
                                                                {
                                                                    sql_command($"UPDATE texnology SET TEXT = '{message.Text}' WHERE id = 1;",
                                                                        data_users);
                                                                    await botClient.SendTextMessageAsync(message.Chat.Id,
                                                                        "<b>Готово !</b>", parseMode: ParseMode.Html,
                                                                        replyMarkup: replyKeyboardMarkup_Kirill);
                                                                    dnevnik = "";

                                                                }
                                                            }
                                                        }
                                                    }
                                                    
                                                            
                                                }
                                            }
                                        }

                                        break;
                                }

                                break;
                        }
        }

        async static Task<Task> Error(ITelegramBotClient botClient, Exception exception,
            CancellationToken cancellationToken)
        {

            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }

        static string da()
        {
            async Task sql_dnevnik_math()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "math";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{math}{text}\n";
                                                    }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_obshetvo()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "obshetvo";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{obshetvo}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_odnknr()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "odnknr";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{odnknr}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_englis_e_v()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "englis_e_v";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{englis_e_v}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_russian()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "russian";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{russian}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_english_s_v()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "english_s_v";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{english_s_v}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_geography()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "geography";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{geography}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_biology()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "biology";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{biology}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_literatur()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "literatur";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{literatur}{text}\n";                                        }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_history()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "history";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{history}{text}\n";


                                                    }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_texnology()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "texnology";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{texnology}{text}\n";


                                                    }
                                                }

                                            }
                                        }
                                        async Task sql_dnevnik_music()
                                        {

                                            using (var connection = new SqliteConnection(data_users))
                                            {
                                                connection.Open();
                                                var selectCmd = connection.CreateCommand();
                                                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "music";
                                                using (var reader = selectCmd.ExecuteReader())
                                                {
                                                    while (reader.Read())
                                                    {
                                                        var text = reader.GetString(0);
                                                        otpr_bufer += $"\n{music}{text}\n";


                                                    }
                                                }

                                            }
                                        }
            DateTime ClockInfoFromSystem = DateTime.Now;
            switch ((int)ClockInfoFromSystem.DayOfWeek + 1)
            {
                case 2:
                    otpr_bufer += "\nДомашнее задание на вторник : \n";
                    sql_dnevnik_literatur();
                    sql_dnevnik_math();
                    sql_dnevnik_russian();
                    
                    sql_dnevnik_history();
                    sql_dnevnik_englis_e_v();
                    sql_dnevnik_english_s_v();
                    return otpr_bufer;
                    otpr_bufer = "";
                    break;
                case 3:
                    otpr_bufer += "\nДомашнее задание на среду : \n";
                    sql_dnevnik_englis_e_v();
                    sql_dnevnik_english_s_v();
                    sql_dnevnik_geography();
                    sql_dnevnik_russian();
                    sql_dnevnik_music();
                    
                    
                    return otpr_bufer;
                    otpr_bufer = "";
                    break;

                case 4:
                    otpr_bufer += "\nДомашнее задание на четверг : \n";
                    sql_dnevnik_history();
                    sql_dnevnik_englis_e_v();
                    sql_dnevnik_english_s_v();
                    sql_dnevnik_math();
                    sql_dnevnik_russian();
                    
                    sql_dnevnik_literatur();
                    
                    
                    
                    
                    return otpr_bufer;
                    otpr_bufer = "";
                    break;
                case 5:
                    otpr_bufer += "\nДомашнее задание на пятницу : \n";
                    sql_dnevnik_russian();
                    sql_dnevnik_obshetvo();
                    sql_dnevnik_math();
                    sql_dnevnik_odnknr();
                    
                    
                    
                    return otpr_bufer;
                    otpr_bufer = "";
                    break;
                case 6:
                    otpr_bufer += "\nДомашнее задание на понедельник : \n";
                    sql_dnevnik_russian();
                    sql_dnevnik_math();
                    sql_dnevnik_texnology();
                    sql_dnevnik_literatur();
                    sql_dnevnik_biology();
                    
                    
                    return otpr_bufer;
                    otpr_bufer = "";
                    break;
                case 7:
                    otpr_bufer += "\nДомашнее задание на понедельник : \n";
                    sql_dnevnik_russian();
                    sql_dnevnik_math();
                    sql_dnevnik_texnology();
                    sql_dnevnik_literatur();
                    sql_dnevnik_biology();
                    
                    return otpr_bufer;
                    otpr_bufer = "";
                    break;
                case 8:
                    otpr_bufer += "\nДомашнее задание на понедельник : \n";
                    sql_dnevnik_russian();
                    sql_dnevnik_math();
                    sql_dnevnik_texnology();
                    sql_dnevnik_literatur();
                    sql_dnevnik_biology();
                    
                    return otpr_bufer;
                    otpr_bufer = "";
                    break;



                default:
                    return "Что - то сломалось";

            }



        }
        /*
                    sql_dnevnik_math();
                    sql_dnevnik_obshetvo();
                    sql_dnevnik_odnknr();
                    sql_dnevnik_englis_e_v();
                    sql_dnevnik_english_s_v();
                    sql_dnevnik_russian();
                    sql_dnevnik_geography();
                    sql_dnevnik_biology();
                    sql_dnevnik_literatur();
                    sql_dnevnik_history();
                    sql_dnevnik_texnology();
        */

        static bool admins(Int64 chel)
        {
            using (var connection = new SqliteConnection(data_users))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "admins";
                using (var reader = selectCmd.ExecuteReader())
                {
                    bool f = false;
                    while (reader.Read())
                    {
                        string[] text = reader.GetString(0).Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine(text[0]);
                        foreach (var VARIABLE in text)
                        {
                            if (long.Parse(VARIABLE) == chel)
                            {
                                f = true;
                                break;

                            }
                        }
                    }

                    return f;
                }

            }
        }

        static async Task add_admins(string chel)
        {
            using (var connection = new SqliteConnection(data_users))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "admins";
                using (var reader = selectCmd.ExecuteReader())
                {
                    bool f = false;
                    while (reader.Read())
                    {
                        string text = reader.GetString(0);
                        Console.WriteLine(text);
                        Console.WriteLine($"UPDATE admins SET text = {text + " " + chel} where text = '{text}'");
                        sql_command($"UPDATE admins SET text = '{text + " " + chel}' where text = '{text}'",data_users);

                    }


                }

            }
        }


        async Task add_texnology_mans(string chto)
        {
            using (var connection = new SqliteConnection(data_users))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "texnology_mans";
                using (var reader = selectCmd.ExecuteReader())
                {
                    var text = reader.GetString(0);
                    sql_command($"UPDATE texnology_mans SET text = {text + " " + chto} where text = '{text}'",data_users);

                }

            }
        }

        static bool texnology_mans(Int64 chel)
        {
            using (var connection = new SqliteConnection(data_users))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "texnology_mans";
                using (var reader = selectCmd.ExecuteReader())
                {
                    bool f = false;
                    while (reader.Read())
                    {
                        string[] text = reader.GetString(0).Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        foreach (var VARIABLE in text)
                        {
                            if (long.Parse(VARIABLE) == chel)
                            {
                                f = true;
                                break;

                            }
                        }
                    }

                    return f;
                }

            }
        }
        async Task remove_admins(string chto)
        {
            using (var connection = new SqliteConnection(data_users))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "admins";
                using (var reader = selectCmd.ExecuteReader())
                {
                    var text = reader.GetString(0);
                    sql_command($"UPDATE admins SET text = {text.Replace(chto,"")} where text = '{text}'",data_users);

                }

            }
        }
        async Task remove_texnology_mans(string chto)
        {
            using (var connection = new SqliteConnection(data_users))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"SELECT " + "*" + @" FROM " + "texnology_mans";
                using (var reader = selectCmd.ExecuteReader())
                {
                    var text = reader.GetString(0);
                    sql_command($"UPDATE texnology_mans SET text = {text.Replace(chto,"")} where text = '{text}'",data_users);

                }

            }
        }



        static ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
        {
            new KeyboardButton[] { "Хранилище", "Записать в хранилеще" },
            new KeyboardButton[] { "/start", "Электронный дневник" },
            new KeyboardButton[] { "Калькулятор дробей", "НОД и НОК" }
        })
        {
            ResizeKeyboard = true
        };

        static ReplyKeyboardMarkup dnevnik______1 = new(new[]
        {
            new KeyboardButton[] { "Написть ДЗ" },
            new KeyboardButton[] { "Опубликовать" },
            new KeyboardButton[] { "/start" },
        })
        {
            ResizeKeyboard = true
        };

        static ReplyKeyboardMarkup replyKeyboardMarkup_Kirill = new(new[]
        {
            new KeyboardButton[] { "Хранилище", "Записать в хранилеще" },
            new KeyboardButton[] { "Электронный дневник", "НОД и НОК" },
            new KeyboardButton[] { "/start", "Калькулятор дробей", "Список людей" },
        })
        {
            ResizeKeyboard = true
        };

        static ReplyKeyboardMarkup replyKeyboardMarkup_Texnology = new(new[]
        {
            new KeyboardButton[] { "Написть Технологию" },
            new KeyboardButton[] { "/start" },
        })
        {
            ResizeKeyboard = true
        };

        static InlineKeyboardMarkup inlainknopka(string text, string calldata)
        {
            InlineKeyboardMarkup knopka = new(new[]
            {
                // first row
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: text, callbackData: calldata),
                },

            });
            return knopka;
        }

        static InlineKeyboardMarkup vbor()
        {
            InlineKeyboardMarkup vbor_uroka = new(new[]
            {

                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "Математика : ", callbackData: "math"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "Обществознание :", callbackData: "obshetvo"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "ОДНКНР : ", callbackData: "odnknr"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "Английский язык(Яна Вячеславовна) : ",
                        callbackData: "englis_e_v"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "Русский язык : ", callbackData: "russian"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "Английский язык(Светлана Владимировна) :",
                        callbackData: "english_s_v"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "География : ", callbackData: "geography"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "Биология : ", callbackData: "biology"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "Литература : ", callbackData: "literatur"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "История : ", callbackData: "history"),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: "Технология : ", callbackData: "texnology"),
                },
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "Музыка : ", callbackData: "music"),
                }

            });
            return vbor_uroka;
        }



        static InlineKeyboardMarkup inlainknopka12(string text1, string calldata1, string text2, string calldata2)
        {
            InlineKeyboardMarkup knopka = new(new[]
            {
                // first row
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: text1, callbackData: calldata1),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: text2, callbackData: calldata2),
                },

            });
            return knopka;
        }

        static InlineKeyboardMarkup inlainknopka5(string text1, string calldata1, string text2, string calldata2,
            string text3, string calldata3, string text4, string calldata4, string text5, string calldata5)
        {
            InlineKeyboardMarkup knopka = new(new[]
            {
                // first row
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: text1, callbackData: calldata1),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: text2, callbackData: calldata2),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: text3, callbackData: calldata3),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: text4, callbackData: calldata4),
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(text: text5, callbackData: calldata5),
                },

            });
            return knopka;
        }

        private static string data_users = $"Data Source={put}/DataBase.db";
        private static Dictionary<Int64, string> storage_knopka = new Dictionary<Int64, string>();

        static void sql_command(string commad, string data_suers)
        {
            using (var connection = new SqliteConnection(data_suers))
            {
                connection.Open();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = commad;
                createTableCmd.ExecuteNonQuery();

            }
        }

        static void sql_remove_data(Int64 id, string tabel, string collumn, string data_users)
        {
            using (var connection = new SqliteConnection(data_users))
            {
                connection.Open();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = $@"
               DELETE FROM {tabel} WHERE {collumn} == {id}
            ";
                createTableCmd.ExecuteNonQuery();

            }
        }

        static void sql_remove_TABEL(string name_tabel, string data_users)
        {
            using (var connection = new SqliteConnection(data_users))
            {
                connection.Open();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = $@"
               DROP TABLE {name_tabel};
            ";
                createTableCmd.ExecuteNonQuery();

            }
        }


    }
}
