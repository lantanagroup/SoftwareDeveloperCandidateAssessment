Welcome to the Lantana Consulting Group **Software Developer Assessment Project**.

This project consists of two modules:

  - The **Server** module: a RESTful API that provides functionality to manage a set of `Book`s.
  - The **Client** module: an Angular UI that allows a user to invoke this functionality via a web browser.

Your task is to implement missing functionality (stubbed out and marked by `NotImplementedException`s and/or `TODO`s):

  - In the Server module:
      - Implement CRUD functionality in `BookDatabaseRepository`.
      - Implement REST endpoints in `BookController`.
      - In both cases, consider starting with the `GetBooks`/`GetBook` methods.
  - In the Client module:
      - Update `app.component.html` to display a table of existing `Book`s.
      - Update `app.component.html` to display a form containing fields describing a single `Book`.
      - Update `app.component.ts` to submit this form, creating a new `Book`.

Keep in mind: the goal is *not* (necessarily) to develop a working solution by the end of the assessment.
Rather, the goal is to provide insight into your thought process as you work on this task.
"Thinking out loud" is encouraged.
