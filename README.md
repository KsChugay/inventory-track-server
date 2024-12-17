# Программное средство учета пермещения и списания материальных ценностей предприятия

## Примеры экранов UI
[UI-компоненты системы](https://www.figma.com/design/eruxol7S4odDJ8vf6cXbnH/%D0%94%D0%B8%D0%BF%D0%BB%D0%BE%D0%BC?node-id=0-1&t=uYLjZTFfFm0JaBfw-1)

## Архитектура
[C4 Container](https://github.com/KsChugay/Diplom/blob/master/docs/C4-Container.png)

[C4 Component](https://github.com/KsChugay/Diplom/blob/master/docs/C4-Component.png)

[Диаграмма классов]()

[ER diagram](https://github.com/KsChugay/Diplom/blob/master/docs/ERD-diagram.png)

[Диаграмма последовательности](https://github.com/KsChugay/inventory-track-server/blob/main/docs/D_posled.png)

[Диаграмма развертывания](https://github.com/KsChugay/inventory-track-server/blob/main/docs/D_rasvert.png)

[Use case diagram](https://github.com/KsChugay/inventory-track-server/blob/main/docs/Use_case.png)


## User flow диаграммы
[User flow diagram_1](https://github.com/KsChugay/Diplom/blob/master/docs/User_flow_1.png), 
[User flow diagram_2](https://github.com/KsChugay/Diplom/blob/master/docs/User_flow_2.png), 
[User flow diagram_3](https://github.com/KsChugay/Diplom/blob/master/docs/User_flow_3.png)

## Swagger API

[Документация](https://github.com/KsChugay/inventory-track-server/blob/main/docs/auth_swagger.json)


## Tests
[Оценка качества кода](https://github.com/KsChugay/inventory-track-server/blob/main/docs/Оценка_качества.jpg)
[Test1](https://github.com/KsChugay/inventory-track-server/blob/main/docs/UserServiceTest.cs)
[Test2](https://github.com/KsChugay/inventory-track-server/blob/main/docs/TokenServiceTest.cs)
[Test3](https://github.com/KsChugay/inventory-track-server/blob/main/docs/AuthServiceTest.cs)


## Развёртывание с использованием Docker

1. **Клонируйте репозиторий**:
   ```bash
   git clone https://github.com/KsChugay/inventory-track-server.git
   cd inventory-track-server
   ```

2. **Перейдите к директории с Dockerfile**:
   ```bash
   cd inventory-track-server/inventory-track-server
   ```

3. **Постройте Docker-образ**:
   ```bash
   docker build -t inventory-track-server .
   ```

4. **Запустите контейнер с передачей параметров подключения к базе данных**:
   ```bash
   docker run -d -p 8080:8080 \
     -e SPRING_DATASOURCE_URL=jdbc:postgresql://<ваш-хост>:<ваш-порт>/<ваша-база> \
     -e SPRING_DATASOURCE_USERNAME=<ваш-юзер> \
     -e SPRING_DATASOURCE_PASSWORD=<ваш-пароль> \
     --name inventory-track-server inventory-track-server
   ```

5. **Проверьте работу приложения**:
   Перейдите в браузере по адресу [http://localhost:8080](http://localhost:8080).
   


