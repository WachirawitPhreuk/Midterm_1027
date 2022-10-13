enum MenuUnregistered {
    RegisterNewParticipant = 1,
    GetListPersons,
    LoginUser
}

enum MenuUser {
    RegisterNewParticipant = 1,
    GetListCurrentStudent,
    GetListStudent,
    GetListTeacher,
    LogoutUser
}

class Program {

    static PersonList personList;    
    static bool Login;
    static void PreparePersonList() {
        Program.personList = new PersonList();
    }
    static void Main(string[] args) {
       Login = false;
       Console.Clear();
        PrintMenuScreen();
    }
    static void PrintMenuScreen() {
        Console.Clear();

        checkLoginStatus();
    }
//เช็คว่าล็อคอินหรือยัง
    static void checkLoginStatus() {
        if(Login){PrintListLoginMenu();
        InputLoginMenuFromKeyboard();}
        else{PrintListNoLoginMenu();
        InputNoLoginMenuFromKeyboard();}
    }
//ยังไม่ล็อกอิน
    static void PrintListNoLoginMenu() {
        Console.WriteLine("Welcome to Idia Camp 2022");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Registration");
        Console.WriteLine("2. Get List of Participant");
        Console.WriteLine("3. Login");
        Console.WriteLine("****************************************************");
    }

    static void InputNoLoginMenuFromKeyboard() {
        Console.Write("Please input Menu:");
        MenuUnregistered menu = (MenuUnregistered)(int.Parse(Console.ReadLine()));

        PresentNoLoginMenu(menu);
    }
//จบ
//ล็อกอินแล้ว
static void PrintListLoginMenu() {
        Console.WriteLine("Welcome to Idia Camp 2022");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Registration");
        Console.WriteLine("2. Get List of Current College Student");
        Console.WriteLine("3.Get List of High-School Student");
        Console.WriteLine("4.Get List of Teachers");
        Console.WriteLine("5. Logout");
        Console.WriteLine("****************************************************");
    }

    static void InputLoginMenuFromKeyboard() {
        Console.Write("Please input Menu:");
        MenuUser menu = (MenuUser)(int.Parse(Console.ReadLine()));

        PresentLoginMenu(menu);
    }
//จบ
    static void PresentNoLoginMenu(MenuUnregistered menu) {
        switch (menu) {
            case MenuUnregistered.RegisterNewParticipant:
                InputNewParticipant();
                break;
            case MenuUnregistered.GetListPersons:
                
                break;
            case MenuUnregistered.LoginUser:
                ShowLoginUser();
                break;
            default:
                break;
        }
    }
//ของหน้าที่ Login แล้ว
    static void PresentLoginMenu(MenuUser menu) {
        switch (menu) {
            case MenuUser.RegisterNewParticipant:
            InputNewParticipant();
            break;
            case MenuUser.GetListCurrentStudent:
            
            break;
            case MenuUser.GetListStudent:
            
            break;
            case MenuUser.GetListTeacher:
            
            break;
            case MenuUser.LogoutUser:
            Login = false;
            Console.Clear();
            checkLoginStatus();
            break;
        }
    }
//ตั้งแต่ส่วนนี้เป็นการเพิ่มผู้ใช้ใหม่
    static void InputNewParticipant() {
        Console.Clear();
        Console.WriteLine("What are your occupation?");
        Console.WriteLine("1. Current College Student");
        Console.WriteLine("2. High-School Student");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("************");

        int x = int.Parse(Console.ReadLine());
        if(x == 1) {
            InputNewCollegeStudent();
        }
        else if(x == 2) {
            InputNewHighSchoolStudent();
        }
        if(x == 3) {
            InputNewTeacher();
        }
        else {
            PrintMenuScreen();
        }
    }
    static void InputNewCollegeStudent() {
        Console.WriteLine("Register new current college student: ");
        Console.Write("Input Title: ");
        string title = TitleMenu();
        Console.Write("Input First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Input student ID: ");
        string studentID = Console.ReadLine();
        Console.Write("Input age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Input your allergic: ");
        string allergic = Console.ReadLine();
        Console.Write("Input religion: ");
        string religion =  ReligionMenu();
        Admin();
    }
    static void InputNewHighSchoolStudent() {
        Console.WriteLine("Register new high school student: ");
        Console.Write("Input Title: ");
        string title = TitleMenu();
        Console.Write("Input First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Input age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Input grade: ");
        string grade = GradeMenu();
        Console.Write("Input your allergic: ");
        string allergic = Console.ReadLine();
        Console.Write("Input religion: ");
        string religion =  ReligionMenu();
    }
    static void InputNewTeacher() {
        Console.WriteLine("Register new current college student: ");
        Console.Write("Input Title: ");
        string title = TitleMenu();
        Console.Write("Input First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Input age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Input your position: ");
        string position = PositionMenu();
        Console.Write("Input your allergic: ");
        string allergic = Console.ReadLine();
        Console.Write("Input religion: ");
        string religion =  ReligionMenu();
        TeachersCar();
        Admin();
    }
//อันนี้ถามว่า 'ใช่แอดมินอ่ะป่าว???'    
    static void Admin() {
        Console.Write("Are you an admin? (Y/N): ");
        string x = Console.ReadLine();
        switch (x) {
            case "Y":   Console.WriteLine("Input E-mail: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Input Password: ");
                        string password = Console.ReadLine();
                        Console.WriteLine("************");
                        break;
            case "N": break;
            default: break;
        }
    }
//ส่วนนี้ถามเรื่องรถ
    static void TeachersCar() {
        Console.WriteLine("Are you bringing your car to the camp? (Y/N)");
        string x = Console.ReadLine();
        switch(x) {
            case "Y":  Console.WriteLine("Input your car number");
                        string carNumber = Console.ReadLine();
                        break;
            case "N": break;
            default: break;
        }
    }
//จบ
//ล็อกอิน
    static void ShowLoginUser() {
        Console.Clear();

        InputLoginUserFromKeyboard();
    }

    static void InputLoginUserFromKeyboard() {
        
        Console.WriteLine("Input E-mail: ");
        string email = Console.ReadLine();
        Console.WriteLine("Input Password: ");
        string password = Console.ReadLine();
        Console.WriteLine("************");

        if(email == "exit") {
            PrintMenuScreen();
        }
        else {
            Console.Clear();
            Login = true;
            checkLoginStatus();
        }
    }
//ส่วนนี้คือคือเลือกข้อมูล

    static string TitleMenu() {
        Console.WriteLine("What is your title?");
        Console.WriteLine("1. Mr.");
        Console.WriteLine("2. Ms.");
        Console.WriteLine("3. Miss");
        int x = int.Parse(Console.ReadLine());
        switch (x) {
            case 1 : return "Mr. ";
            case 2 : return "Ms. ";
            case 3 : return "Miss ";
            default : return TitleMenu();
        }
    }
    static string ReligionMenu() {
        Console.WriteLine("What is your religion?");
        Console.WriteLine("1. Buddhist");
        Console.WriteLine("2. Christ");
        Console.WriteLine("3. Islam");
        Console.WriteLine("4. Other");
        int x = int.Parse(Console.ReadLine());
        switch (x) {
            case 1 : return "Mr. ";
            case 2 : return "Ms. ";
            case 3 : return "Miss ";
            case 4 : return Console.ReadLine();
            default : return TitleMenu();
        }
    }
    static string GradeMenu() {
        Console.WriteLine("What is your grade?");
        Console.WriteLine("1. M.4 / Grade 10");
        Console.WriteLine("2. M.5 / Grade 11");
        Console.WriteLine("3. M.6 / Grade 12");
        int x = int.Parse(Console.ReadLine());
        switch (x) {
            case 1 : return "M.4 / Grade 10 ";
            case 2 : return "M.5 / Grade 11 ";
            case 3 : return "M.6 / Grade 12 ";
            default : return GradeMenu();
        }
    }
    static string PositionMenu() {
        Console.WriteLine("What is your position?");
        Console.WriteLine("1. Dean");
        Console.WriteLine("2. Head of department");
        Console.WriteLine("3. Professor");
        int x = int.Parse(Console.ReadLine());
        switch (x) {
            case 1 : return "Dean";
            case 2 : return "Head of Department";
            case 3 : return "Professor";
            default : return PositionMenu();
        }
    }
}