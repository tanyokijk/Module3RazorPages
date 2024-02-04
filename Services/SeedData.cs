using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Services;

public static class SeedData
{
    public static List<Movie> GetInitialMovies()
    {
        var adventures = new Style { Name = "пригоди" };
        var animation = new Style { Name = "анімація" };
        var comedy = new Style { Name = "комедія" };
        var romance = new Style { Name = "романтика" };
        var drama = new Style { Name = "драма" };
        var family = new Style { Name = "сімейний" };
        var thriller = new Style { Name = "трилер" };
        var action = new Style { Name = "екшн" };
        var biopic = new Style { Name = "байопік" };
        var historical = new Style { Name = "історичний" };
        var detective = new Style { Name = "детектив" };
        var biography = new Style { Name = "біографія" };
        var sports = new Style { Name = "спортивний" };
        var mysticism = new Style { Name = "містика" };
        var horror = new Style { Name = "горор" };

        var movie1 = new Movie
        {
            Id = 1,
            Name = "Переліт",
            Producer = "Бенжамін Реннер, Джайло Хомсі",
            Photo = "https://smartcinema.ua//media/img/perelt/poster.jpg",
            Description = "Нова анімаційна пригода від Illumination – творців таких хітів, як «Посіпаки», «Нікчемний Я», «Співай» і «Секрети домашніх тварин», на великих екранах! Цього Різдва вирушайте у яскраву сімейну подорож далеко за межі звичного в оригінальній історії «Переліт»!",
            Styles = new List<Style> { adventures, animation },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 2, DateTime = new DateTime(2024, 2, 5, 9, 50, 0) },
                new Session { RoomNumber = 2, DateTime = new DateTime(2024, 2, 5, 11, 50, 0)  },
                new Session { RoomNumber = 2, DateTime = new DateTime(2024, 2, 5, 13, 50, 0) },
                new Session { RoomNumber = 2, DateTime = new DateTime(2024, 2, 5, 15, 50, 0) },
                new Session { RoomNumber = 2, DateTime = new DateTime(2024, 2, 5, 17, 50, 0) },
            }
        };

        var movie2 = new Movie
        {
            Id = 2,
            Name = "Люблю тебе ненавидіти",
            Photo = "https://smartcinema.ua//media/img/ljublju-tebe-nenavidti/poster.jpg",
            Description = "На ранок після ідеального першого побачення фатальна пристрасть закоханих перетворюється на холодну ненависть, доки доля не зводить їх разом на весіллі друзів в Австралії. Тож їм не залишається нічого іншого, окрім як вчинити по-дорослому і знову прикинутися парою.",
            Producer = "Вілл Ґлак",
            Styles = new List<Style> { comedy, romance },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 4, DateTime = new DateTime(2024, 2, 5, 10, 40, 0) },
                new Session { RoomNumber = 4, DateTime = new DateTime(2024, 2, 5, 12, 50, 0) },
                new Session { RoomNumber = 1, DateTime = new DateTime(2024, 2, 5, 14, 00, 0) },
                new Session { RoomNumber = 4, DateTime = new DateTime(2024, 2, 5, 15, 00, 0) },
                new Session { RoomNumber = 1, DateTime = new DateTime(2024, 2, 5, 16, 10, 0) },
                new Session { RoomNumber = 3, DateTime = new DateTime(2024, 2, 5, 16, 40, 0) },
                new Session { RoomNumber = 4, DateTime = new DateTime(2024, 2, 5, 17, 10, 0) },
                new Session { RoomNumber = 1, DateTime = new DateTime(2024, 2, 5, 18, 20, 0) },
                new Session { RoomNumber = 3, DateTime = new DateTime(2024, 2, 5, 18, 50, 0) },
                new Session { RoomNumber = 4, DateTime = new DateTime(2024, 2, 5, 19, 20, 0) },
                new Session { RoomNumber = 1, DateTime = new DateTime(2024, 2, 5, 20, 30, 0) },
                new Session { RoomNumber = 4, DateTime = new DateTime(2024, 2, 5, 21, 30, 0) },
            }
        };

        var movie3 = new Movie
        {
            Id = 3,
            Name = "Як там Катя?",
            Producer = "Крістіна Тинькевич",
            Photo = "https://smartcinema.ua//media/img/jak-tam-katja/poster.PNG",
            Description = "Анна — лікарка швидкої допомоги та одинока мати є опорою для своєї родини — сестри, матері та єдиної доньки Каті. Анна — сильна жінка, яка планує подарувати своєї дитині краще життя, ніж у неї. Але сталася неочікувана та шокуюча трагедія, яка може все зруйнувати та залишити героїню на одинці з байдужою системою та безмежною втратою.",
            Styles = new List<Style> { drama },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 6, DateTime = new DateTime(2024, 2, 5, 9, 10, 0) },
                new Session { RoomNumber = 6, DateTime = new DateTime(2024, 2, 5, 13, 50, 0)  },
            }
        };

        var movie4 = new Movie
        {
            Id = 4,
            Name = "СуперАлібі 2",
            Producer = "Філіпп Лашо",
            Photo = "https://smartcinema.ua//media/img/superalb-2/poster.PNG",
            Description = "Ґреґ був власником агентства, яке допомагало клієнтам створювати правдоподібні алібі. Закривши його, він зажив спокійним і безтурботним життям та вирішив освідчитися своїй коханій дівчині Фло. Однак, є проблема. Ґреґ не хоче знайомити Фло зі своєю матірʼю та нечистим на руку батьком. Щоб уникнути цього, він знову відкриває агентство і тепер шукає фальшивих батьків для себе.",
            Styles = new List<Style> { comedy, adventures },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 4, DateTime = new DateTime(2024, 2, 5, 9, 00, 0) },
            }
        };

        var movie5 = new Movie
        {
            Id = 5,
            Name = "Історія Тіто та Вінні",
            Producer = "Серхіо Мачадо",
            Photo = "https://smartcinema.ua//media/img/storja-tto-ta-vnn/poster.jpg",
            Description = "Пара мишей намагається сісти на Ноїв ковчег. Вінні, харизматичний поет, який страшенно боїться сцени, і Тіто, талановитий чарівний гітарист. На Ноїв ковчег допускаються лише один самець і одна самка кожного виду. Завдяки щасливій долі та допомозі геніального таргана, Вінні і Тіто пробираються на ковчег, де мають запобігти протистоянню між хижаками та травоїдними. Чи зможуть ці талановиті безбілетні мандрівники використати музику, щоб зняти напругу та допомогти всім створінням пережити 40 днів і 40 ночей разом?",
            Styles = new List<Style> { family,  },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 1, DateTime = new DateTime(2024, 2, 5, 10, 00, 0) },
                new Session { RoomNumber = 2, DateTime = new DateTime(2024, 2, 5, 21, 50, 0)  },
            }
        };

        var movie6 = new Movie
        {
            Id = 6,
            Name = "Догмен",
            Producer = "Люк Бессон",
            Photo = "https://smartcinema.ua//media/img/dogmen/poster.jpg",
            Description = "В цьому світі він любить і розуміє тільки собак, а вони безвідмовно виконують усі його накази. В дитинстві жорстокий батько знущався з хлопця. Зрештою, щоб позбутись, кинув до зграї бродячих псів, сподіваючись, що дикі собаки розірвуть хлопця. Зараз Догмен має власну моральну шкалу, і тому, коли місто захоплює нарокобарон, він вирішує позбавити світ від \"бруду\" своїми методами. Ця зграя готова прийняти бій, щоб знищити злочинну імперію та відновити мир на вулицях міста.",
            Styles = new List<Style> { thriller, action },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 3, DateTime = new DateTime(2024, 2, 5, 14, 20, 0) },
            }
        };

        var movie7 = new Movie
        {
            Id = 7,
            Name = "Ґолда",
            Producer = "Ґай Наттів",
            Photo = "https://smartcinema.ua//media/img/olda/poster.jpg",
            Description = "1973 рік. «Війна судного дня» у розпалі. Єгипет, Сирія та Йорданія атакують Ізраїль, сподіваючись повернути собі втрачені території. Вирішити цей конфлікт має Ґолда Меїр — перша жінка-прем'єр-міністр Ізраїлю. Тягар відповідальності за долю країни ще важчий тому, що за фасадом «залізної леді» Ґолда ховає один похмурий секрет.",
            Styles = new List<Style> { biopic, drama },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 3, DateTime = new DateTime(2024, 2, 5, 10, 10, 0) },
            }
        };

        var movie8 = new Movie
        {
            Id = 8,
            Name = "Сісі і я",
            Producer = "Фрауке Фінстервальдер",
            Photo = "https://smartcinema.ua//media/img/ss-ja/poster.jpg",
            Description = "Графиня Ірма стає супутницею найпопулярнішої жінки своєї доби. Вона подорожуватиме зі знаменитою Сісі, стане її подругою, і навіть без тями закохається в монархиню. Цей безтурботний час міг би тривати вічно, якби Сісі не була імператрицею. І хоча жінки чинять опір ворожому світові, зрештою в них лишається тільки один фатальний шлях, який назавжди зв’яже їх обох.",
            Styles = new List<Style> { biopic, historical },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 6, DateTime = new DateTime(2024, 2, 5, 18, 30, 0) },
            }
        };

        var movie9 = new Movie
        {
            Id = 9,
            Name = "Арґайл",
            Producer = "Метью Вон",
            Photo = "https://smartcinema.ua//media/img/arajl/poster.jpg",
            Description = "Популярна авторка шпигунських бестселерів Еллі Конвей обожнює проводити час вдома за комп’ютером і в компанії улюбленого кота Алфі. Проте коли сюжети вигаданих книг Еллі, в центрі яких — секретний агент Арґайл та його місія з розкриття глобального шпигунського синдикату, починають відображати таємні дії реальної шпигунської організації, тихі домашні вечори залишаються в минулому.",
            Styles = new List<Style> { detective, action },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 5, DateTime = new DateTime(2024, 2, 5, 10, 30, 0) },
                new Session { RoomNumber = 7, DateTime = new DateTime(2024, 2, 5, 12, 20, 0) },
                new Session { RoomNumber = 5, DateTime = new DateTime(2024, 2, 5, 13, 20, 0) },
                new Session { RoomNumber = 7, DateTime = new DateTime(2024, 2, 5, 15, 10, 0) },
                new Session { RoomNumber = 5, DateTime = new DateTime(2024, 2, 5, 16, 10, 0) },
                new Session { RoomNumber = 7, DateTime = new DateTime(2024, 2, 5, 18, 00, 0) },
                new Session { RoomNumber = 5, DateTime = new DateTime(2024, 2, 5, 19, 00, 0) },
                new Session { RoomNumber = 7, DateTime = new DateTime(2024, 2, 5, 20, 50, 0) },
            }
        };

        var movie10 = new Movie
        {
            Id = 10,
            Name = "Моє прекрасне весілля",
            Producer = "Роджер Камбл",
            Photo = "https://smartcinema.ua//media/img/mo-prekrasne-vesllja/poster.jpg",
            Description = "Ділан Спроус та Вірджинія Гарднер повертаються до ролей Тревіса та Еббі, які прокинулись після божевільної ночі в Лас-Вегасі виявляють, що одружені. Вони вирушають до Мексики на \"медовий місяць\" із друзями та родиною. Але звісно, все піде зовсім не за планом неочікуваних \"молодят\". На пару чекають нові сюрпризи, смішні історії та можливий хепі-енд…",
            Styles = new List<Style> { comedy, romance },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 7, DateTime = new DateTime(2024, 2, 5, 10, 20, 0) },
                new Session { RoomNumber = 3, DateTime = new DateTime(2024, 2, 5, 12, 20, 0) },
                new Session { RoomNumber = 2, DateTime = new DateTime(2024, 2, 5, 19, 50, 0) },
            }
        };

        var movie11 = new Movie
        {
            Id = 11,
            Name = "Шлях до слави: Лянча проти Ауді",
            Producer = "Стефано Мордіні",
            Photo = "https://smartcinema.ua//media/img/shljah-do-slavi-ljancha-proti-aud/poster.jpg",
            Description = "Це неймовірна історія Чемпіонату світу з ралі 1983 року. У реальній історії Давида проти Голіафа ми бачимо, як відважні аутсайдери команди Lancia на чолі з харизматичним Чезаре Фіоріо (Скамарчіо) протистояли могутній команді Audi в одному з найбільших змагань в історії спорту.",
            Styles = new List<Style> { biography, drama, sports },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 1, DateTime = new DateTime(2024, 2, 5, 12, 00, 0) },
                new Session { RoomNumber = 3, DateTime = new DateTime(2024, 2, 5, 20, 50, 0) },
            }
        };

        var movie12 = new Movie
        {
            Id = 12,
            Name = "Володар хаосу",
            Producer = "Вільям Брент Белл",
            Photo = "https://smartcinema.ua//media/img/volodar-haosu/poster.jpg",
            Description = "Натуральне господарство, будинок, оточений віковими деревами - справжня мрія сім'ї, що втомилася від столиці. Тут, у затишному містечку, де всі один одного знають, вони готуються зустріти овіяне легендами язичницьке свято. У розпал урочистості зникає дочка — але здається, ніхто не поспішає її шукати.",
            Styles = new List<Style> { mysticism, horror },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 5, DateTime = new DateTime(2024, 2, 5, 21, 40, 0) },
            }
        };

        var movie13 = new Movie
        {
            Id = 13,
            Name = "Ідеальні дні",
            Producer = "Вім Вендерс",
            Photo = "https://smartcinema.ua//media/img/dealn-dn/poster.jpeg",
            Description = "Історія про Хіраяму — прибиральника туалетів у Токіо. Він повністю задоволений своїм простим життям: дотримується структурованого розпорядку дня, а вільний час присвячує своїй пристрасті — слуханню рок-музики, читанню книг та вирощуванню дерев. Однак усе більше деталей про життя Хіраями та його особисті якості розкривається через низку несподіваних зустрічей.",
            Styles = new List<Style> { drama },
            Sessions = new List<Session>
            {
                new Session { RoomNumber = 6, DateTime = new DateTime(2024, 2, 5, 11, 20, 0) },
                new Session { RoomNumber = 6, DateTime = new DateTime(2024, 2, 5, 16, 00, 0) },
                new Session { RoomNumber = 6, DateTime = new DateTime(2024, 2, 5, 21, 10, 0) },
            }
        };

        return new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10, movie11, movie12, movie13 };
    }
}