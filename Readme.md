*   Это телеграм бот https://t.me/kirill_official_bot 
* Для его использования требуеться создать самостоятельно два файла 

* Первый Файл - config.cs :
```csharp
public static class Config
{
    public static string TelegramApiKey = "{ВАШ АПИ КЛЮЧ}";
}
```
* Второй файл - DataBase.db:
  * Это база данных sqlite 
  * В ней 19 таблиц
  * Название                ::             Переменные
  * ```
    admins                  ::             TEXT TEXT
    biology                 ::             TEXT id
    data_users              ::             INT id_sql(Он как авто ключ) ; INT id ; TEXT date
    englis_e_v              ::             TEXT TEXT ; INT id_sql(Он как авто ключ)           
    english_s_v             ::             TEXT TEXT ; INT id_sql(Он как авто ключ)  
    geography               ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    history                 ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    literatur               ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    log                     ::             INT id_sql(Он как авто ключ) ; INT id ; TEXT log
    math                    ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    music                   ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    obshetvo                ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    odnknr                  ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    people                  ::             INT id_sql(Он как авто ключ) ; INT id ; TEXT male
    russian                 ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    texnology               ::             TEXT TEXT ; INT id_sql(Он как авто ключ)
    texnology_mans          ::

    ```
  