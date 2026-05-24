# TaskHub API

Практический проект на ASP.NET Core Web API (.NET 8).

**TaskHub API** — это backend-приложение, приближенное к реальным рабочим задачам. В рамках проекта мы шаг за шагом создаём полноценный REST API для управления проектами, задачами, комментариями и пользователями.

Проект развивается в рамках серии:

> [**Практика с ASP.NET Core Web API (.NET 8)**](https://ghostbasenji.github.io/series/praktika-s-aspnet-core-web-api-dotnet-8/)

## Что будет реализовано

- JWT-аутентификация
- Роли и авторизация
- Управление проектами
- Управление задачами
- Система комментариев
- Entity Framework Core
- PostgreSQL
- Валидация
- Глобальная обработка ошибок
- Логирование
- Пагинация, фильтрация, сортировка
- Docker
- Swagger / OpenAPI

## Технологии

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- JWT Authentication
- Swagger / OpenAPI

## Структура проекта

```txt
TaskHub/
│── src/
│   └── TaskHub.Api/
│
│── TaskHub.sln
│── README.md
```

## Быстрый старт

### Клонирование репозитория

```bash
git clone URL_РЕПОЗИТОРИЯ
```

### Запуск проекта

```bash
cd TaskHub/src/TaskHub.Api
dotnet run
```

Swagger UI:

```txt
https://localhost:xxxx/swagger
```

## Прогресс серии

- [x] Часть 1 — Создание проекта
- [x] Часть 2 — Структура проекта и подготовка архитектуры
- [ ] Часть 3 — Настройка базы данных и EF Core
- [ ] Часть 4 — Аутентификация и JWT
- [ ] Продолжение следует...

## Цель проекта

Создать production-like ASP.NET Core Web API, используя современные подходы разработки и реальные backend-сценарии.

## Лицензия

Проект создан в образовательных целях и для портфолио.
