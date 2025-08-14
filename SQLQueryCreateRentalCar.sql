-- Tabela de Usuários do Sistema
PRINT 'Criando Tabela TB_Users...';
CREATE TABLE TB_Users
(
    IdUser      INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    UserName    VARCHAR(50) UNIQUE NOT NULL,
    UserPass    VARCHAR(255) NOT NULL        
);
GO

-- Tabela de Clientes
PRINT 'Criando Tabela TB_Customers...';
CREATE TABLE TB_Customers
(
    CustId      INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    CustName    VARCHAR(100) NOT NULL,
    CustAddress VARCHAR(255) NOT NULL,
    CustPhone   VARCHAR(20) NOT NULL,
    CPF_CNPJ    VARCHAR(18) UNIQUE NOT NULL
);
GO

-- Tabela de Carros
PRINT 'Criando Tabela TB_Cars...';
CREATE TABLE TB_Cars
(
    CarId       INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    RegNum      VARCHAR(50) UNIQUE NOT NULL,
    Brand       VARCHAR(50) NOT NULL,
    Model       VARCHAR(50) NOT NULL,
    Avaliable   VARCHAR(3) NOT NULL DEFAULT 'Yes',
    Price       DECIMAL(10, 2) NOT NULL
);
GO

-- Tabela de Aluguéis (Registra a SAÍDA do carro)
PRINT 'Criando Tabela TB_Rent...';
CREATE TABLE TB_Rent
(
    RentId      INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    CarId_FK    INT NOT NULL,
    CustId_FK   INT NOT NULL,
    RentDate    DATE NOT NULL DEFAULT GETDATE(),
    RentFee     DECIMAL(10, 2) NOT NULL,

    CONSTRAINT FK_Rent_Car FOREIGN KEY (CarId_FK) REFERENCES TB_Cars(CarId),
    CONSTRAINT FK_Rent_Customer FOREIGN KEY (CustId_FK) REFERENCES TB_Customers(CustId)
);
GO

-- Tabela de Devoluções (Registra a ENTRADA do carro)
PRINT 'Criando Tabela TB_Return...';
CREATE TABLE TB_Return
(
    ReturnId    INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    RentId_FK   INT UNIQUE NOT NULL, -- Ligação única com o aluguel original.
    ReturnDate  DATE NOT NULL DEFAULT GETDATE(),
    Delay       INT NULL,            -- Atraso em dias (calculado pela aplicação)
    Fine        DECIMAL(10, 2) NULL, -- Multa pelo atraso (calculada pela aplicação)

    CONSTRAINT FK_Return_Rent FOREIGN KEY (RentId_FK) REFERENCES TB_Rent(RentId)
);
GO

PRINT 'Banco de dados recriado com sucesso com a estrutura final!';