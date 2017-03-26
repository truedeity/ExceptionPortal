Whats the goal?

1st goal is to create an portal to view exceptions.  Project details to come later.
2nd goal is to create an full-stack application framework for asp.net core 
	(this should be seperated from the exception portal as a reusable tempalte, this tempalte will be saved to a branch named tempalte)
	sub goals
		1. adhere to specific database standards.
			a. All tables must have IsSuppressed, CreatedDt, CreatedByUserId, UpdatedDt, UpdatedByUserId, LastUpdatedGuid, EntityGuid columns.
			b. more to be listed here...
		2. adhere to open such as DI, SOLID, etc.
			a. consider using simple injector over microsofts home grown di 
		3. provide a generic repository pattern that works with any type of entities.
			a. this should include a SqlRepository and SqlUnitOfWork 
		4. provide a default scaffolding of controllers and views that renders an elegant ui for all crud operations
			a. crud operations are create, read, update, delete. 
			b. bootstrapped ui
			c. confirmation/modal dialogs for delete
			d. create modal for any general entity
			f. out of the box drop down menus for code tables
			e. out of the box validations 
		5. easy to implement caching mechanism, should be attribute based.
			a. consider using a redis provider for caching
		6. provide a layer for application logic
		7. avoid using microsoft tables  for authentication
			a. instead of AspNetUsers => User
			b. Instead of User.Id => User.UserId
			etc..
		8. do not use session, user id should be saved in a bearer/jwt token
		9. an architecture that allows lazy loading
