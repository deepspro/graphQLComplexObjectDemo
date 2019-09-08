# graphQL ComplexObject Demo

Example of nested JSON
```
{
  "response": {
    "books": [
      {
        "id": 1,
        "title": "",
        "published" : "",
        "publisher" : "",
        "description" : "",
        "authors": [
          {
            "firstName": "",
            "lastName": ""
          },
          {
            "firstName": "",
            "lastName": ""
          }
        ],
         "categories" : [""]
      }
    ]
  }
}
```

To get all the data of books the graphQL query will be 
```
{
  response{
    books{
      title
      authors{
        firstName
      }
      categories
    }
  }
}
```


Below is the query to get the book details by using id.
Note: Pass the parameter id in QUERY VARIABLE dashboard.
```
query Sample($id: Int)
{
  response{
    book(id:$id){
      title
      authors{
        firstName
      }
      categories
    }
  }
}
```