const myLink="http://localhost:53848/api/student";
document.getElementById('B1').addEventListener('click',getData);

function getData(){
    var requests={
        method:'GET',
        redirect:'follow'
    };
    fetch(myLink,requests)
    .then(res=>res.text())
    .then(result=>showData(result));
}
function showData(data){
    document.getElementById('content').innerHTML=data;
}

//get element by id
document.getElementById('B2'),addEventListener('click',getOneRecord);

function getOneRecord(){
    var id=document.getElementById("ibox").value;

    var myLink='http://localhost:53848/api/student/'+id;
    console.log(id);
    fetch(myLink)
    .then(res =>res.text())
    .then(result=>showRecords(result))

    .catch(error=>console.log('Error!',error));
}

    function showRecords(data){
        document.getElementById('content').innerHTML=data;
    }

    function sendJSON(){
        let  studentName = document.getElementById("name");
         let age = document.getElementById("age");
         let gender  = document.getElementById("gender");
         let course  = document.getElementById("course");
         let university = document.getElementById("university");
         let city = document.getElementById("city");
        
        // Creating a XHR object
        let xhr = new XMLHttpRequest();   
        let url = "http://localhost:53848/api/student";
        
        // open a connection
        
        xhr.open("POST", url, true);
        
        // Set the request header i.e. which type of content you are sending
        
        xhr.setRequestHeader("Content-Type", "application/json");
        
        // Create a state change callback
        
        xhr.onreadystatechange = function () {
        
        if (xhr.readyState === 4 && xhr.status === 200) {
      
        // Print received data from server
        
        result.innerHTML = this.responseText;
       
        }
        };
        
        // Converting JSON data to string
        
        var data = JSON.stringify({ "studentName": studentName.value , "age":age.value,"gender":gender.value ,"course":course.value,"university":university.value,"city":city.value });
        
        // Sending data with the request
        
        xhr.send(data);
        
        
        
        }
