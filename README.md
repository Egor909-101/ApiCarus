# API для продажи автомобилей

## 1. Название продукта
**CarSales API** — RESTful API для управления продажей автомобилей.

---

## 2. Введение или краткое описание
CarSales API — это RESTful API, разработанное на платформе ASP.NET Core, которое позволяет управлять продажей автомобилей. API предоставляет возможности для создания, чтения, обновления и удаления (CRUD) данных о пользователях, автомобилях, покупках и отзывах.

Этот проект предназначен для разработчиков, которые хотят создать платформу для продажи автомобилей.

---

## 3. Необходимые условия для использования продукта
Для использования проекта необходимо иметь следующие знания и инструменты:

1. **ASP.NET Core**: Для разработки и запуска веб-приложения.
2. **Entity Framework Core**: Для работы с базой данных.
3. **MS SQL Server**: Для хранения данных.
4. **Visual Studio или Visual Studio Code**: Для разработки и отладки.
5. **Postman или аналогичный инструмент**: Для тестирования API.
6. **Базовые знания C#**: Для понимания кода.
7. **Базовые знания RESTful API**: Для работы с API.

---

## 4. Как установить программу

### Шаг 1: Установка .NET SDK
1. Скачайте и установите .NET SDK с официального сайта: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
2. Убедитесь, что .NET SDK установлен, выполнив команду:
   ```bash
   dotnet --version
   ```

### Шаг 2: Клонирование репозитория
1. Клонируйте репозиторий с GitHub:
   ```bash
   git clone https://github.com/ваш-репозиторий/car-sales-api.git
   ```
2. Перейдите в папку проекта:
   ```bash
   cd car-sales-api
   ```

### Шаг 3: Настройка базы данных
1. Откройте файл `appsettings.json` и настройте строку подключения к вашей базе данных:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=ваш-сервер;Database=CarSalesDB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```
2. Выполните миграции для создания базы данных:
   ```bash
   dotnet ef database update
   ```

### Шаг 4: Запуск проекта
1. Запустите проект с помощью команды:
   ```bash
   dotnet run
   ```
2. Откройте браузер и перейдите по адресу `http://localhost:5000/swagger` для просмотра документации API через Swagger.

---

## 5. Порядок использования

### Регистрация и авторизация
1. Отправьте POST-запрос на `/api/User` для создания нового пользователя:
   ```json
   {
       "email": "user@example.com",
       "passwordHash": "hashedPassword",
       "fullName": "John Doe",
       "phoneNumber": "+1234567890",
       "registrationDate": "2023-10-01T00:00:00Z"
   }
   ```
2. Используйте GET-запрос на `/api/User/{id}` для получения данных пользователя.

### Управление автомобилями
1. Отправьте POST-запрос на `/api/Car` для добавления нового автомобиля:
   ```json
   {
       "brand": "Toyota",
       "model": "Camry",
       "year": 2018,
       "mileage": 50000,
       "price": 15000.00,
       "description": "Great condition, well-maintained."
   }
   ```
2. Используйте GET-запрос на `/api/Car` для получения списка всех автомобилей.

### Покупка автомобиля
1. Отправьте POST-запрос на `/api/Purchase` для покупки автомобиля:
   ```json
   {
       "buyerId": 1,
       "carId": 1,
       "price": 15000.00
   }
   ```

### Отзывы
1. Отправьте POST-запрос на `/api/Review` для добавления отзыва:
   ```json
   {
       "userId": 1,
       "carId": 1,
       "rating": 5,
       "reviewText": "Great car!",
       "reviewDate": "2023-10-01T12:00:00Z"
   }
   ```

### Примеры запросов
- Получение всех пользователей:
  ```bash
  GET /api/User
  ```
- Получение всех автомобилей:
  ```bash
  GET /api/Car
  ```
- Удаление пользователя:
  ```bash
  DELETE /api/User/1
  ```

### Дополнительная документация
Подробная документация по API доступна через Swagger по адресу `http://localhost:5000/swagger`.

---

## 6. Ссылки
- [Документация по ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0)
- [Документация по Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [Репозиторий проекта на GitHub](#) (укажите ссылку на ваш репозиторий).
