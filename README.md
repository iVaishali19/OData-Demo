# OData Demo
Check overview of OData here 
https://learn.microsoft.com/en-us/odata/overview
for this run the application and try below url to check how with query string for select and filer or  orderby etc can be done direclty from url

https://localhost:7125/api/student?$select=id,Name

https://localhost:7125/api/student?$filter=Name eq ’Vaishu'

https://localhost:7125/api/student?$filter=Score gt 20165

https://localhost:7125/api/student?$filter=Name in ('Vaishu','Vanshu')

https://localhost:7125/api/student?$orderby=Name 

https://localhost:7125/api/student?$orderby=Name desc
