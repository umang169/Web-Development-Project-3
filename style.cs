* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Poppins', sans-serif;
}

body {
  background-image: url("./assets/bg.png");
  background-repeat: no-repeat;
  background-size: 100%;
}

nav {
  display: flex;
  justify-content: space-around;
  align-items: center;
  background-color: black;
  padding: 10px 30px;
}

nav .line {
  width: 1px;
  height: 40px;
  background-color: #fff;
  margin-right: 80px;
}

nav .logo img {
  width: 60%;
}

nav ul {
  display: flex;
  gap: 40px;
  margin-right: 700px;
}

nav ul li a {
  list-style: none;
  color: white;
  font-weight: 700;
}

.btn-small button {
  width: 100px;
  padding: 6px 10px;
  background: #ba0cc5;
  color: white;
  cursor: pointer;
  border-radius: 5%;
}

.btn-small button:hover {
  background-color: #840d8d;
}

section {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  height: 90vh;
  color: #fff;
}

section h1 {
  font-size: 60px;
  text-align: center;
}

section p {
  font-size: 24px;
}

.btn-large {
  margin-top: 60px;
}
.btn-large button{background-color: #ba0cc5;color: white;
padding: 14px 46px;
border: none;
border-radius: 8px;cursor: pointer;}

.btn-large button:hover {
  background-color: #840d8d;
}
