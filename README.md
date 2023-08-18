# NjustSchoolNet
A tool for autherizing access of school internet without open a web page in Nanjing University of Science and Technology

# Usage

0. Install .net core 3.1 or above(not .net framework)
1. Download release
2. Run `NjustSchoolNet.exe`
3. If you are using WLAN, connect your device to the WLAN then enter username and password, press "Login"

//... TODO


# Arguments

* ### login
example:
```
./NjustSchoolNet.exe login username password
```
* ### logout
example:
```
./NjustSchoolNet.exe logout
```

* ### logauto
Program will read the stored username and password to login
example:
```
./NjustSchoolNet.exe logauto
```

* ### dial
Dail an existing PPPoE when username and password not provided, program will read Windows stored data
example:
```
./NjustSchoolNet.exe dial
./NjustSchoolNet.exe dial username password
```
* ### dialauto
Dial using this program stored data.
example:
```
./NjustSchoolNet.exe dialauto
```
* ### hang
Hang up the number N connection PPPoE connection in system.
If argument N is not provided, it will default be 0 which is the first connectiong connetion.
example:
```
./NjustSchoolNet.exe hang N
./NjustSchoolNet.exe hang
```

