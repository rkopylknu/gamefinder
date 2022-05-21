# gamefinder

## Інструкція з встановлення:
1. Завантажте та розпакуйте архів програми
2. Запустіть командний рядок (cmd.exe) від імені адміністратора
3. За допомогою командного рядка (cmd.exe) запустіть *mongod.exe*, встановивши для параметра *port* значення 27017

   Приклад команди:
   ```
   C:\Users\User\Documents\mongodb\bin\mongod --port 27017
   ```
4. Запустіть *mongo.exe* від імені адміністратора
5. Виконайте наступні команди для очищення бази даних з назвою *gamestores*:
   ```
   use gamestores
   db.dropDatabase()
   ```
6. Відкрийте папку "gamefinder-main", отриману після видобування файлів з архіву
7. Перейдіть за шляхом "gamefinder-main\GameFinder\bin\Debug"
8. Запустіть GameFinder.exe

Якщо всі шляхи було виконано правильно, повинен запуститися Windows Forms застосунок з початковим набором даних

## Інструкція з користування:

Застосунок складається з двох основних екранів: Екрану пошуку (SearchForm) та Екрану сховища (StorageForm)

### Екран пошуку:

![Екран пошуку](images/searchform-screenshot.png?raw=true)

#### На Екрані пошуку присутні наступні компоненти:
- Поле введення пошукового запиту - Для введення повної назви / частини назви шуканої гри
- Спіннер вибору виробника - Для вказання виробника шуканої гри
- Прапорець сортування за ціною - Для сортування знайдених ігор за ціною в порядку зростання
- Кнопка пошуку - Для здійснення пошуку на основі даних, введених в попередніх компонентах
- Кнопка відкриття *екрану кошика*
- Таблиця результатів пошуку
   - Для відображення знайдених в результаті пошуку ігор
   - Для вибору гри (поточна обрана гра виділяється голубим кольором)
- Кнопка переходу до *екрана сховища*
- Поле введення кількості ігор - Для введення кількості ігор, що будуть додані до кошика
- Кнопка додання до кошика - Для додання до кошика гри, обраної в таблиці результатів пошуку, в кількості, вказаній в полі введення кількості ігор

![Екран кошика](images/cartform-screenshot.png?raw=true)

#### На Екрані кошика присутні наступні компоненти:
- Таблиця доданих до кошика ігор
   - Для відображення доданих до кошика ігор
   - Для вибору гри (поточна обрана гра виділяється голубим кольором)
- Кнопка видалення - Для видалення з кошика гри, обраної в таблиці доданих до кошика ігор
- Поле загальної суми - Для відображення загальної суми покупки на основі ціни та кількості ігор
- Кнопка очищення кошика - Для видалення з кошика всіх ігор
- Кнопка здійснення покупки - Після натсикання, з сховища списується відповідна кількість ігор

### Екран сховища:

![Екран сховища](images/storageform-screenshot.png?raw=true)

#### На Екрані сховища присутні наступні компоненти:
- Таблиця магазинів
   - Для відображення всіх магазинів, збережених в системі
   - Для вибору магазину (поточний обраний магазин виділяється помаранчевим кольором)
- Кнопка створення магазину - Для відкриття *екрану створення магазину*
- Кнопка видалення магазину - Для видалення магазину, обраного в таблиці магазинів
- Таблиця виробників
   - Для відображення всіх виробників, збережених в системі
   - Для вибору виробника (поточний обраний виробник виділяється помаранчевим кольором)
- Кнопка створення виробника - Для відкриття *екрану створення виробника*
- Кнопка видалення магазину - Для видалення виробника, обраного в таблиці виробників
 - Таблиця ігор
   - Для відображення всіх ігор, збережених в системі
   - Для вибору гри (поточна обрана гра виділяється помаранчевим кольором)
- Кнопка збільшення кількості ігор - Для збільшення кількості обраної в таблиці ігор гри на 1
- Кнопка зменшення кількості ігор - Для зменшення кількості обраної в таблиці ігор гри на 1
- Кнопка створення гри - Для відкриття *екрану створення гри*
- Кнопка видалення гри - Для видалення гри, обраної в таблиці ігор
- Кнопка переходу до *екрана пошуку*

#### Екран створення магазину:
![Екран створення магазину](images/createstoreform-screenshot.png?raw=true)
#### Екран створення виробника:
![Екран створення виробника](images/createmanufacturerform-screenshot.png?raw=true)
#### Екран створення гри:
![Екран створення гри](images/creategamesform-screenshot.png?raw=true)
