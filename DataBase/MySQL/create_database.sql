CREATE DATABASE agenda_medica;
USE agenda_medica;

CREATE TABLE Medico (
	IdMedico INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100),
    Especialidade VARCHAR(100),
    Foto VARCHAR(255)
);

CREATE TABLE Paciente (
	IdPaciente INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100),
    Telefone VARCHAR(20)
);

CREATE TABLE Consulta (
	IdConsulta INT AUTO_INCREMENT PRIMARY KEY,
    IdMedico INT,
    IdPaciente INT,
    Data DATE,
    Hora TIME,
    Obervacao TEXT,
    FOREIGN KEY (IdMedico) REFERENCES Medico(IdMedico),
    FOREIGN KEY (IdPaciente) REFERENCES Paciente(IdPaciente)
);