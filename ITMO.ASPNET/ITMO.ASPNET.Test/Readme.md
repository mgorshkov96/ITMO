#Key Decision Document
##Model (EF -MSSQL)
1. Students  Table
- Id (int, not null, identity);
- Name (varchar[20], not null);
- Surname (varchar[30], not null);
- ScoreId (int, not null).
2. Score  Table (целое/список) – справочник (ввод данных заранее)
- Id (int, not null, identity);
- ScoreValue (smallint, not null);
- ScoreDescr (varchar[10], null);
- FK (Students.ScoreId ßà Score.Id).
##Views (HTML)
1. Student (UI – Add – V1) + Validation - form
- Name;
- Surname;
- Score.
2. Students (UI – All Info (Detailed) – V2) - grid
- Name;
- Surname;
- Score.
3. Student (UI – Delete – V3) – grid + multiple select
4. Вывод суммы всех ScoreValue баллов (UI – V4) - view
5. Best/notBest (UI – V5) - view
6. MVC Layout Page (all, my design) + Navigation
##Controller - StudentsController
1. Add (GET)
2. Add (POST)
3. AllInfo (GET)
4. Delete (GET)
5. Delete (POST)
6. SumView (GET) – BL (Sum)- class
7. BestView (GET) – DB (Sort) - SP
