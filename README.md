Argentum – это небольшая утилита, которую я написал на .NET для автоматизации расчетов результатов химических анализов, проводимых на Глазовском комбикормовом заводе.

Фичи:
- реализованы расчеты для трех видов измерений, перечисленных ниже (натрий, сырой протеин по Кьельдалю, хлориды);
- простой файл настроек, позволяющий запоминать некоторые дефолтные параметры, свойственные конкретной лаборатории (размер используемой мерной колбы) или ситуации (точная концентрация раствора, приготовленного на этой неделе);
- дефолтные значения можно менять из-под GUI программы;
- дефолтные значения защищены от случайного изменения или удаления: чтобы выполнить изменение или удаление, нужно поставить галочку;
- текущие значения по умолчанию можно сбрасывать в дефолтные (эту опцию также можно отключать).

Виды расчетов и соответствующие ГОСТы:
- Определение содержания натрия в комбикормах потенциометрическим методом. ГОСТ 13496.1-98. https://docs.cntd.ru/document/1200024317
- Определение содержания сырого протеина по Кьельдалю. ГОСТ 32044.1-2012. https://docs.cntd.ru/document/1200105311
- Определение содержания хлоридов аргентометрическим методом. ГОСТ 13496.1-2019. https://docs.cntd.ru/document/1200166799
