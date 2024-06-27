Hello! Welcome to the Lantana Consulting Group Full Stack Developer Assessment Project!

This solution comprises of 2 parts:
	1. A RESTful API that provides a list of Books.
	2. An Angular front-end that consumes the API and displays the list of Books.

Your job will be to:
	1. Implement the RESTful API.
		a. LantanGroup.CandidateAssessment.Server.Controllers.BookController
			i. Implement all controller methods.
		b. LantanaGroup.CandidateAssessment.Server.Repositories.BookDatabaseRepository
			i. Implement all CRUD methods.
	2. Implement the Angular front-end.
		a. Update app.component.html to add table fields and a submission form for new entries.
		b. Update app.component.html.ts for form submission to backend.

The expectation at the end of the exercise is for lantanagroup.candidateassessment.client to be
able to perform the following:
	1. Get all books and display them.
	2. Delete a book from the database.
	3. Update a book.
	4. Create a new book.