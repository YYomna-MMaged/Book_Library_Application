/*create database Book library;*/

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     5/8/2024 12:23:24 PM                         */
/*==============================================================*/

/*create database project;*/
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN') and o.name = 'FK_ADMIN_ADMIN_USER')
alter table ADMIN
   drop constraint FK_ADMIN_ADMIN_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_INCLUDE_DEPARTME')
alter table BOOK
   drop constraint FK_BOOK_INCLUDE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_MANAGE_ADMIN')
alter table BOOK
   drop constraint FK_BOOK_MANAGE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_PUBLISH_PUBLISHE')
alter table BOOK
   drop constraint FK_BOOK_PUBLISH_PUBLISHE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_RELATIONS_BORROW')
alter table BOOK
   drop constraint FK_BOOK_RELATIONS_BORROW
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK_COPY') and o.name = 'FK_BOOK_COP_HAS_BOOK')
alter table BOOK_COPY
   drop constraint FK_BOOK_COP_HAS_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_RELATIONS_STUDENT')
alter table BORROW
   drop constraint FK_BORROW_RELATIONS_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_RELATIONS_BOOK')
alter table BORROW
   drop constraint FK_BORROW_RELATIONS_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('student') and o.name = 'FK_STUDENT_STUDENT_USER')
alter table student
   drop constraint FK_STUDENT_STUDENT_USER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'Relationship_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.Relationship_8_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'PUBLISH_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.PUBLISH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'INCLUDE_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.INCLUDE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.MANAGE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK_COPY')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK_COPY.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK_COPY')
            and   type = 'U')
   drop table BOOK_COPY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'Relationship_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.Relationship_7_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'Relationship_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.Relationship_6_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BORROW')
            and   type = 'U')
   drop table BORROW
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEPARTMENT')
            and   type = 'U')
   drop table DEPARTMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBLISHER_COMPANY')
            and   type = 'U')
   drop table PUBLISHER_COMPANY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USER_PHONE')
            and   type = 'U')
   drop table USER_PHONE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('student')
            and   type = 'U')
   drop table student
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   UID                  numeric(10)           not null,
   salary               numeric(7)           not null,
   constraint PK_ADMIN primary key (UID)
)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   Title                varchar(30)          not null,
   price                numeric(5)           not null,
   author               varchar(30)          not null,
   publication_year     numeric(4)           not null,
   B_ISBN               numeric(10)          not null,
   DPID                 numeric(10)           not null,
   C_NAME               varchar(30)           not null,
   UID                  numeric(10)           not null,
   BOR_UID              numeric(10)           null,
   BOR_B_ISBN           numeric(10)          null,
   constraint PK_BOOK primary key nonclustered (B_ISBN)
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/
create index MANAGE_FK on BOOK (
UID ASC
)
go

/*==============================================================*/
/* Index: INCLUDE_FK                                            */
/*==============================================================*/
create index INCLUDE_FK on BOOK (
DPID ASC
)
go

/*==============================================================*/
/* Index: PUBLISH_FK                                            */
/*==============================================================*/
create index PUBLISH_FK on BOOK (
C_NAME ASC
)
go

/*==============================================================*/
/* Index: Relationship_8_FK                                     */
/*==============================================================*/
create index Relationship_8_FK on BOOK (
BOR_UID ASC,
BOR_B_ISBN ASC
)
go

/*==============================================================*/
/* Table: BOOK_COPY                                             */
/*==============================================================*/
create table BOOK_COPY (
   Version_no           numeric(10)          not null,
   ISBN                 numeric(10)          not null,
   constraint PK_BOOK_COPY primary key nonclustered (Version_no, ISBN)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on BOOK_COPY (
ISBN ASC
)
go

/*==============================================================*/
/* Table: BORROW                                                */
/*==============================================================*/
create table BORROW (
   UID                  numeric(10)          not null,
   B_ISBN               numeric(10)          not null,
   Start_date           datetime             not null,
   End_data             datetime             not null,
   Fees                 numeric(10)          not null,
   constraint PK_BORROW primary key (UID)
)
go

/*==============================================================*/
/* Index: Relationship_6_FK                                     */
/*==============================================================*/
create index Relationship_6_FK on BORROW (
UID ASC
)
go

/*==============================================================*/
/* Index: Relationship_7_FK                                     */
/*==============================================================*/
create index Relationship_7_FK on BORROW (
B_ISBN ASC
)
go

/*==============================================================*/
/* Table: DEPARTMENT                                            */
/*==============================================================*/
create table DEPARTMENT (
   DPID                 numeric(10)           not null,
   name                 varchar(50)           not null,
   location             varchar(50)          not null,
   constraint PK_DEPARTMENT primary key nonclustered (DPID)
)
go

/*==============================================================*/
/* Table: PUBLISHER_COMPANY                                     */
/*==============================================================*/
create table PUBLISHER_COMPANY (
   C_NAME               varchar(30)           not null,
   mail                 varchar(30)          not null,
   city                 varchar(20)          null,
   street               varchar(15)          null,
   building             numeric(3)           null,
   constraint PK_PUBLISHER_COMPANY primary key nonclustered (C_NAME)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   password             numeric(8)           not null,
   email                varchar(30)          not null,
   first_name           varchar(30)           not null,
   last_name            varchar(30)           null,
   city                 varchar(20)          null,
   street               varchar(15)          null,
   UID                  numeric(10)           not null,
   constraint PK_USER primary key nonclustered (UID)
)
go

/*==============================================================*/
/* Table: USER_PHONE                                            */
/*==============================================================*/
create table USER_PHONE (
   user_id              numeric(10)           not null,
   phone_number         numeric(13)          not null,
   constraint PK_USER_PHONE primary key nonclustered (user_id, phone_number)
)
go

/*==============================================================*/
/* Table: student                                               */
/*==============================================================*/
create table student (
   UID                  numeric(10)           not null,
   graduation_year      numeric(4)           not null,
   major                varchar(30)          null,
   constraint PK_STUDENT primary key (UID)
)
go

alter table USER_PHONE
   add constraint FK_ADMIN_USER_PHONE foreign key (user_id)
      references "USER" (UID)

alter table ADMIN
   add constraint FK_ADMIN_ADMIN_USER foreign key (UID)
      references "USER" (UID)
go

alter table BOOK
   add constraint FK_BOOK_INCLUDE_DEPARTME foreign key (DPID)
      references DEPARTMENT (DPID)
go

alter table BOOK
   add constraint FK_BOOK_MANAGE_ADMIN foreign key (UID)
      references ADMIN (UID)
go

alter table BOOK
   add constraint FK_BOOK_PUBLISH_PUBLISHE foreign key (C_NAME)
      references PUBLISHER_COMPANY (C_NAME)
go

/*alter table BOOK
   add constraint FK_BOOK_RELATIONS_BORROW foreign key (BOR_UID, BOR_B_ISBN)
      references BORROW (UID, B_ISBN)
go*/

alter table BOOK_COPY
   add constraint FK_BOOK_COP_HAS_BOOK foreign key (ISBN)
      references BOOK (B_ISBN)
go

alter table BORROW
   add constraint FK_BORROW_RELATIONS_STUDENT foreign key (UID)
      references student (UID)
go

alter table BORROW
   add constraint FK_BORROW_RELATIONS_BOOK foreign key (B_ISBN)
      references BOOK (B_ISBN)
go

alter table student
   add constraint FK_STUDENT_STUDENT_USER foreign key (UID)
      references "USER" (UID)
go

