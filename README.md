# DockerBasic

## Services:
- ASP.NET Core Web API
- PostgreSQL DB
- Redis Cache

## Setup

1. Clone the repo
2. Run:
   ```bash
   docker-compose --env-file .env.development up --build –d (development environment) 
   or 
   docker-compose --env-file .env.testing up --build –d (Test environment) 
   or 
   docker-compose --env-file .env.production up --build –d (Production environment) 
