EXEC [spCreateTblPessenger] 'PESSENGER', 'First Name', 'Last Name', 'Contact', 'Date_Of_Birth', 'Age', 'Gender';

EXEC spCreateTblWorker 'PERSON', 'First_Name', 'Last_Name', 'Contact', 'Date_Of_birth', 'Age', 'Gender', 'Role', 'Date_Of_Hiring';

EXEC [spCreateTblTrain] 'TRAIN', 'Name', 'Description', 'Type';

EXEC [spCreateTblTrainInfo] 'TRAININFO', 'Seats', 'Arrival Location', 'Arrival Time', 'Departure Time', 'Departure Location', 'Available Seats';

EXEC [spCreateTblCoach] 'COACH', 'Capacity', 'Class', 'Category';

EXEC [spCreateTblTicket] 'TICKET', 'Price', 'Final Price';

EXEC [spCreateTblStation] 'STATION', 'Description', 'Type', 'Name', 'Capacity';

EXEC [spCreateTblRoute] 'ROUTE', 'Name', 'Description', 'Point', 'Pick up point';

EXEC [spCreateTblDependent] 'DEPENDENT', 'Name', 'Date Of Birth', 'Age';

EXEC [spCreateTblAddress] 'ADDRESS', 'City', 'Streat', 'State'

EXEC [spCreateTblAuthentication] 'AUTHENTICATION', 'User Name', 'Email', 'Password', 'Worker_Id'

EXEC [spCreateTblReservation] 'RESERVATION', 'Pessenger_id', 'Train_id', 'TrainInfo_id', 'Ticket_id'
