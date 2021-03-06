html, input { 
    font-family: sans-serif;
}
body {
    padding:5%;
    width: 100%; 
    max-width: 600px; 
    margin: 0px auto; 

    background-image:url('https://img.freepik.com/free-vector/hand-painted-watercolor-pastel-sky-background_23-2148902771.jpg?w=2000');
}
.headerContainer { 
    display: flex;
    flex-flow: column wrap; 
    align-content: center;
    background-color:#008CFF ; 
    font-weight: bold; margin-bottom: 20px;
}
form {
    margin-top: auto;
}
div {
    display: flex;
    margin-bottom: 20px; 
    justify-content: space-between; 
    align-items: center;
}
label, input, button { 
    font-size: 16px; 
    line-height: 1.5
}
label {

    width: 30%; 
    margin-right: 2%;
}
input {
    flex: auto;
}
button {
    width: 70%; margin: 0 auto;
}
error-output {
    font-size: 12px;
    font-style: italic;
    color: red;}