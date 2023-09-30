# Helios API

Table Of Contents (up to date)
- [Helios API](#helios-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstname":"mohhamdreza",
    "lastName":"ahmadi",
    "email":"mohammadre3aahmadi@gmail.com",
    "password":"Amiko123456"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "firstname":"mohhamdreza",
    "lastName":"ahmadi",
    "email":"mohammadre3aahmadi@gmail.com",
    "password":"Amiko123456"
}
```


### Login
```js
POST {{host}}/auth/login
```
### Login Request

```json
{
    "email":"mohammadre3aahmadi@gmail.com",
    "password":"Amiko123456"
}
```

### Login Response
```js
200 OK
```

```json
{
    "firstname":"mohhamdreza",
    "lastName":"ahmadi",
    "email":"mohammadre3aahmadi@gmail.com",
    "password":"Amiko123456"
}
```


