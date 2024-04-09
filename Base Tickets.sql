drop database if exists Tickets;
create database Tickets;
use tickets;

create table Persona(
CodPersona int auto_increment,
Nombre varchar(15),
Apellido Varchar(15),
DNI varchar(8),
Direccion varchar(20),
Telefono varchar(10),
EMail varchar(20),
constraint PK_Persona primary key(CodPersona)
) Engine=InnoDB;

insert into Persona values
('', "Usuario1", "Usuario1", "12345678", "Sarmiento 1551", "1123456789", "usuario1@gmai.com"),
('', "Administrador1", "Administrador1", "87654321", "Sarmiento 1551", "1198765432", "administrador1@gmail.com"),
('', "Usuario2", "Usuario2", "13579113", "Sarmiento 1551", "1113579112", "usuario2@gmail.com");


create table TipoUsuario(
CodTipoUsuario int auto_increment,
ClaseUsuario varchar(40),
constraint PK_TipoUsuario primary key(CodTipoUsuario)
)Engine=InnoDB;

insert into TipoUsuario values
('', "Administrador"),
('', "Usuario");


create table Usuario(
CodUsuario int auto_increment,
CodTipoUsuario int,
CodPersona int,
NombreUsuario varchar(20),
Contrasena varchar(20),
Habilitado boolean,
constraint PK_Usuario primary key(CodUsuario),
constraint FK_Usuario_ foreign key(CodTipoUsuario) references TipoUsuario(CodTipoUsuario),
constraint FK_Usuario__ foreign key(CodPersona) references Persona(CodPersona)
) Engine = InnoDB;

insert into Usuario values
('', 2, 1, "Usuario1", "usuario1", 1),
('', 1, 2, "Administrador1", "administrador1", 1);


create table Ticket(
CodTicket int auto_increment,
CodUsuario int,
CodUsuarioEnviado int,
Asunto varchar(50),
Consulta varchar(500),
FechaEmitido date,
Corregido boolean,
constraint PK_Ticket primary key(CodTicket),
constraint FK_Ticket foreign key(CodUsuario) references Usuario(CodUsuario),
constraint FK_Ticket_ foreign key(CodUsuarioEnviado) references Usuario(CodUsuario)

) Engine=InnoDB;

insert into Ticket values
('', 2, null, "Ticket1", "Ticket1Ticket1Ticket1Ticket1", "2019/10/10", 0),
('', 2, null,"Ticket2", "Ticket2Ticket2Ticket2Ticket2", "2019/10/10", 0);
