﻿using DesignPattersSamples.Behavioral.Observer.Интерфейсы;
using DesignPattersSamples.Behavioral.Observer.Модели;

// ReSharper disable StringLiteralTypo
namespace DesignPattersSamples.Behavioral.Observer
{
    public class Пример
    {
        public void Пример1()
        {
            // Идет строительство многоквартирного дома
            // Квартиры раскупили, заказчики ждут завершения строительства
            // Менеджмент подписал заказчиков на сервис подписки
            IСервисПодписки сервисПодписки = new СервисПодписки();

            var заказчик1 = new Заказчик();
            var заказчик2 = new Заказчик();
            сервисПодписки.ДобавитьКлиента(заказчик1);
            сервисПодписки.ДобавитьКлиента(заказчик2);

            сервисПодписки.УведомитьВсех("Мы вырыли котлован под дом!");
            сервисПодписки.УведомитьВсех("Мы заложили фундамент!");

            сервисПодписки.УведомитьВсех("Мы уже на Канарах! Сорян, это кидок!");
            сервисПодписки.УдалитьКлиента(заказчик1);
            сервисПодписки.УдалитьКлиента(заказчик2);
        }
    }
}