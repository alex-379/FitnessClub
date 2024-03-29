Use [FitnessClub]

Go

Create procedure AddPerson
@RoleId int, @FamilyName nvarchar(20) = null, @FirstName nvarchar(20) = null, @Patronymic nvarchar(20) = null, @PhoneNumber nvarchar(12) = null, @Email nvarchar(40) = null, @DateBirth nvarchar(20) = null, @Sex bit = null, @TelegramUserId bigint = null, @OneTimePassword int = null
As
Begin
Insert dbo.[Persons] 
Output Inserted.Id
Values (@RoleId, @FamilyName, @FirstName, @Patronymic, @PhoneNumber, @Email, @DateBirth, @Sex, @TelegramUserId, @OneTimePassword, 0)
End

Go


Create procedure AddCoachSportType
@CoachId int, @SportTypeId int
As
Begin
Insert dbo.[Coaches_SportTypes]
Values (@CoachId, @SportTypeId)
End

Go

Create procedure AddCoachWorkoutType
@CoachId int, @WorkoutTypeId int
As
Begin
Insert dbo.[Coaches_WorkoutTypes]
Values (@CoachId, @WorkoutTypeId)
End

Go

Create procedure GetAllPersons As
Begin
Select [Id], [RoleId], [FamilyName], [FirstName], [Patronymic], [PhoneNumber], [Email], [DateBirth], [Sex], [TelegramUserId], [OneTimePassword] from dbo.[Persons]
Where [IsDeleted] = 0
End

Go

Create procedure GetPersonById
@Id int
As
Begin
Select [Id], [RoleId], [FamilyName], [FirstName], [Patronymic], [PhoneNumber], [Email], [DateBirth], [Sex], [TelegramUserId], [OneTimePassword] from dbo.[Persons]
Where [Id]=@Id and [IsDeleted] = 0
End

Go

Create procedure UpdatePersonOnId
@Id int, @RoleId int, @FamilyName nvarchar(20), @FirstName nvarchar(20), @Patronymic nvarchar(20), @PhoneNumber nvarchar(12), 
@Email nvarchar(40), @DateBirth nvarchar(40), @Sex bit
As
Begin
Update dbo.[Persons]
Set [RoleId]=@RoleId, [FamilyName]=@FamilyName, [FirstName]=@FirstName, [Patronymic]=@Patronymic, [PhoneNumber]=@PhoneNumber, [Email]=@Email,
[DateBirth]=@DateBirth, [Sex]=@Sex
Where [Id]=@Id
End

Go 

Create procedure DeletePersonById
@Id int
As
Begin
Update dbo.[Persons]
Set  [IsDeleted]=1
Where [Id]=@Id
End

Create procedure UndeletePersonById
@Id int
As
Begin
Update dbo.[Persons]
Set  [IsDeleted]=0
Where [Id]=@Id
End

Go

Create procedure DeleteOneTimePasswordByPersonId
@Id int
As
Begin
Update dbo.[Persons]
Set  [OneTimePassword]="null"
Where [Id]=@Id
End

Go

Create procedure DeleteCoachSportType
@CoachId int, @SportTypeId int
As
Begin
Delete From dbo.[Coaches_SportTypes]
Where [CoachId]=@CoachId and [SportTypeId]=@SportTypeId
End

Go

Create procedure DeleteCoachWorkoutType
@CoachId int, @WorkoutTypeId int
As
Begin
Delete From dbo.[Coaches_WorkoutTypes]
Where [CoachId]=@CoachId and [WorkoutTypeId]=@WorkoutTypeId
End

Go

Create procedure GetAllPersonsByRoleId
@RoleId int
As
Begin
Select P.[Id], P.[FamilyName], P.[FirstName], P.[Patronymic], P.[PhoneNumber], P.[Email], P.[DateBirth], P.[Sex], P.[TelegramUserId], P.[OneTimePassword], R.[Id] As [RoleId], R.[Name] As [Role] From dbo.[Persons] As P
Join dbo.[Roles] As R On P.[RoleId] = R.[Id]
Where P.[RoleId]=@RoleId and P.[IsDeleted]=0
End

Go

Create procedure GetAllCoachesWithSportTypesWorkoutTypes
@RoleId int
As
Begin
Select P.[Id], P.[FamilyName], P.[FirstName], P.[Patronymic], P.[PhoneNumber], P.[Email], P.[DateBirth], P.[Sex], P.[TelegramUserId],P.[OneTimePassword], ST.[Id] As SportTypeId, ST.[Name] as [SportType], WT.[Id] As WorkoutTypeId, WT.[Name] As WorkoutType From dbo.[Persons] As P
join dbo.[Coaches_SportTypes] As CST On P.[Id] = CST.[CoachId]
join dbo.[SportTypes] As ST On CST.[SportTypeId] = ST.[Id]
join dbo.[Coaches_WorkoutTypes] As CWT On P.[Id] = CWT.[CoachId]
join dbo.[WorkoutTypes] As WT On CWT.[WorkoutTypeId] = WT.[Id]
Where P.[RoleId]=@RoleId and P.[IsDeleted]=0
End

Go

Create procedure GetCoachWithSportTypesWorkoutTypesById
@RoleId int, @CoachId int
As
Begin
Select P.[Id], P.[FamilyName], P.[FirstName], P.[Patronymic], P.[PhoneNumber], P.[Email], P.[DateBirth], P.[Sex], P.[TelegramUserId], P.[OneTimePassword], ST.[Id] As SportTypeId, ST.[Name] as [SportType], WT.[Id] As WorkoutTypeId, WT.[Name] As WorkoutType From dbo.[Persons] As P
join dbo.[Coaches_SportTypes] As CST On P.[Id] = CST.[CoachId]
join dbo.[SportTypes] As ST On CST.[SportTypeId] = ST.[Id]
join dbo.[Coaches_WorkoutTypes] As CWT On P.[Id] = CWT.[CoachId]
join dbo.[WorkoutTypes] As WT On CWT.[WorkoutTypeId] = WT.[Id]
Where P.[Id]=@CoachId and P.[RoleId]=@RoleId and P.[IsDeleted]=0
End

Go