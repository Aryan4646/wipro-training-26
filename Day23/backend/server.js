const express = require("express");

const app = express();
const PORT = 5000;

app.use(express.json()); // built-in body parser

let users = [
  { id: 1, name: "Aryan" },
  { id: 2, name: "Rahul" }
];

// GET API
app.get("/users", (req, res) => {
  res.json(users);
});

// POST API
app.post("/users", (req, res) => {

  const newUser = {
    id: users.length + 1,
    name: req.body.name
  };

  users.push(newUser);

  res.json(newUser);
});

app.listen(PORT, () => {
  console.log(`Server running on port ${PORT}`);
});