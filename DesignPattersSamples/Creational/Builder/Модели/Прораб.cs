﻿using DesignPattersSamples.Creational.Builder.Интерфейсы;

namespace DesignPattersSamples.Creational.Builder.Модели
{
    public class Прораб : IПрораб
    {
        private IСтроитель _строитель;

        public void НазначитьСтроителя(IСтроитель строитель)
        {
            _строитель = строитель;
        }

        public void ПостроитьБюджетныйДом()
        {
            _строитель.ПостроитьДом(1, 3);
        }

        public void ПостроитьОбычныйДом()
        {
            _строитель.ПостроитьДом(2, 4);
            _строитель.ПостроитьГараж(1);
            _строитель.СделатьДорожки();
        }

        public void ПостроитьПремиумДом()
        {
            _строитель.ПостроитьДом(3, 7);
            _строитель.ПостроитьГараж(2);
            _строитель.УстановитьБассейн();
            _строитель.СделатьДорожки();
            _строитель.ПосадитьСад();
        }
    }
}