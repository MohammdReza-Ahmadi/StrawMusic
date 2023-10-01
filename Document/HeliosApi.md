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
  "id": "1755a811-2f0a-4172-a497-bdfc9aad3d2f",
  "firstName": "Mohammad reza",
  "lastName": "ahmadi",
  "email": "manv.ma123@gmail.com",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxNzU1YTgxMS0yZjBhLTQxNzItYTQ5Ny1iZGZjOWFhZDNkMmYiLCJnaXZlbl9uYW1lIjoiTW9oYW1tYWQgcmV6YSIsImZhbWlseV9uYW1lIjoiYWhtYWRpIiwianRpIjoiYzU3MDQ3OTgtNjJjMy00Y2Q3LTg0ZjktOWM0NTI4ZWExZTg0IiwiZXhwIjoxNjk2MTk3MTU2LCJpc3MiOiJIZWxpb3MiLCJhdWQiOiJIZWxpb3MifQ.8H0FOc9R3Q4GZNOM2LbslkNJ6Mrdok_byD4I5lnaxso"
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
  "id": "eaf07526-003a-432a-af1e-219f62a7cddb",
  "firstName": "Mohammad reza",
  "lastName": "ahmadi",
  "email": "manv.ma123@gmail.com",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJlYWYwNzUyNi0wMDNhLTQzMmEtYWYxZS0yMTlmNjJhN2NkZGIiLCJnaXZlbl9uYW1lIjoiTW9oYW1tYWQgcmV6YSIsImZhbWlseV9uYW1lIjoiYWhtYWRpIiwianRpIjoiODU3ZjdkODYtNzQwMS00MjgzLTllYjctYjk5YTJkZDU4ZDI0IiwiZXhwIjoxNjk2MTk3MjM5LCJpc3MiOiJIZWxpb3MiLCJhdWQiOiJIZWxpb3MifQ.hV1E2j_GKt5eIvqnALSrBU-qOUrHFkytE8uqMKueBCg"
}
```


