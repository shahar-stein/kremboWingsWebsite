function CheckUsername() {
    var name = document.myform.name1.value;
    if (name.length == 0) {
        alert("חובה להקליד שם משתמש");
        document.myform.name1.focus();
        return false;
    }
    return true;
}

function CheckPass1() {
    var pass1 = document.myform.pass1.value;
    if (pass1.length < 6) {
        alert("בסיסמא חייבים להיות לפחות 6 תווים");
        document.myform.pass1.value = "";
        document.myform.pass1.focus();
        return false;
    }
    return true;
}

function CheckPass2() {
    pass1 = document.myform.pass1.value;
    pass2 = document.myform.pass2.value;
    if (pass1 != pass2) {
        alert("אימות סיסמא שגוי");
        document.myform.pass2.value = "";
        document.myform.pass2.focus();
        return false;
    }
    return true;
}

function CheckEmail() {
    var badCharStr = "$%^&*#()_+[]{}<>&\",";
    for (var index = 0; index < 16; index++) {
        if (document.myform.mail.value.indexOf(badCharStr.charAt(index)) != -1) {
            alert("bad char " + badCharStr.charAt(index));
            document.myform.mail.value = "";
            document.myform.mail.focus();
            return false;
        }
    }
    return true;
}

function CheckMail()
{
    var str = document.myform.mail.value;
    var data = str.split(".");
    if(data.length<2)
    {
        alert("Email is missing '.'");
        document.myform.mail.value = "";
        document.myform.mail.focus();
        return false;
    }
    if (data[0].length == 0)
    {
        alert("Mail Begins with '.'");
        document.myform.mail.value = "";
        document.myform.mail.focus();
        return false;
    }
    if (data[data.length-1].length == 0)
    {
        alert("Mail ends with '.'");
        document.myform.mail.value = "";
        document.myform.mail.focus();
        return false;
    }
    var data1 = str.split('@');
    if (data1.length ==1) {
        alert("Email is missing a @")
        document.myform.mail.value = "";
        document.myform.mail.focus();
        return false;
    }

    if (data1.length > 2)
    {
        alert("In email only 1 @ allowed")
        document.myform.mail.value ="";
        document.myform.mail.focus();
        return false;
    }
    if ((data1[0].length == 0) || (data1[1].length == 0))
    {
        alert("In email @ not in place");
        document.myform.mail.value = "";
        document.myform.mail.focus();
        return false;
    }
    var data2 = data1[1].split('.');
    if (data2.length > 3)
    {
        alert("in Email domain contains no more than 2 '.'")
        document.myform.mail.value = "";
        document.myform.mail.focus();
        return false;
    }
    return true;
}

function CheckMeil() {
    var answer = true;
    if (document.myform.mail.value.indexOf("@") == -1) {
        alert("No @");
        answer = false;
    }
    if (document.myform.mail.value.indexOf(".") == document.myform.mail.value.length - 1) {
        alert(". last");
        answer = false;
    }
    if (document.myform.mail.value.indexOf("@") == 0) {
        alert("@ first");
        answer = false;
    }
    if ((document.myform.mail.value.length <= 5) || (document.myform.mail.value.length >= 30)) {
        alert("not the right length ");
        answer = false;
    }
    if (!answer) {
        document.myform.mail.value = "";
        document.myform.mail.focus();
    }
    return answer;
}

function CheckSnif() {
    if (document.myform.snif.selectedIndex == 0) {
        alert("Select snif");
        return false;
    }
    return true;
}

function CheckPhone() {
    if (document.myform.phone.value <= 99999999) {
        alert("Phone number must be 10 digits long");
        document.myform.phone.value = "";
        document.myform.phone.focus();
        return false;
    }
    return true;

}



function CheckForm() {
    if (!CheckUsername())
        return false;
    if (!CheckPass1())
        return false;
    if (!CheckPass2())
        return false;
    if (!CheckEmail())
        return false;
    if (!CheckMail())
        return false;
    if (!CheckPhone())
        return false;
    if (!CheckSnif())
        return false;
    return true;
}

function CheckUpdate() {
    if (!CheckPass1())
        return false;
    if (!CheckPass2())
        return false;
    if (!CheckEmail())
        return false;
    if (!CheckMail())
        return false;
    if (!CheckPhone())
        return false;
    return true;
}
