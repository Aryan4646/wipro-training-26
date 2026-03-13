import { useEffect, useState } from "react";

function App() {

  const [users, setUsers] = useState([]);
  const [name, setName] = useState("");

  useEffect(() => {
    fetch("/users")
      .then(res => res.json())
      .then(data => setUsers(data));
  }, []);

  const addUser = (e) => {
    e.preventDefault();

    fetch("/users", {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify({ name })
    })
      .then(res => res.json())
      .then(data => {
        setUsers([...users, data]);
        setName("");
      });
  };

  return (
    <div>
      <h1>User Management</h1>

      <form onSubmit={addUser}>
        <input
          value={name}
          onChange={(e) => setName(e.target.value)}
          placeholder="Enter name"
        />
        <button>Add User</button>
      </form>

      <ul>
        {users.map(user => (
          <li key={user.id}>{user.name}</li>
        ))}
      </ul>

    </div>
  );
}

export default App;