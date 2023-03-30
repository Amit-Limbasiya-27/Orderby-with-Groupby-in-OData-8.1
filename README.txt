Changes:
- first change to odata controller from normal controller i.e. ControllerBase
- add edm model 
- in Student model change the DataMember name as id to Id (first letter capital)


Research Points:
- if we want to apply orderby and groupby both then there should be same attribute for both the operations.
  i.e. if we apply orderby on id then groupby also be applied on id.

- first character of the attribute is CAPITAL in the Model on which the operations is applied 
  otherwise it will give error as:  
  The given key 'Id' was not present in the dictionary. (Error: 500)

