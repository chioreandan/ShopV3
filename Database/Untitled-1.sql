CREATE TABLE Universitati(
     Id INT ,
    NumeUniversitate VARCHAR(255) NOT NULL,
    City VARCHAR(255) NOT NULL,
    Code int NOT NULL PRIMARY Key
    )
    
CREATE TABLE Facultati(
     Id INT NOT NULL,
    NumeFac VARCHAR(255) NOT NULL,
    Code INT FOREIGN KEY REFERENCES Universitati(Code)

    )
