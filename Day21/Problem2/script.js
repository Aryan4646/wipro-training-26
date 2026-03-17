document.getElementById("getUserBtn").onclick = function() {
    fetch("https://randomuser.me/api/")
        .then(res => res.json())
        .then(data => {
            var user = data.results[0];
            var info = "Name: " + user.name.title + " " + user.name.first + " " + user.name.last + "<br>" +
                       "Email: " + user.email + "<br>" +
                       "<img src='" + user.picture.large + "' alt='Profile Picture'>";
            document.getElementById("userInfo").innerHTML = info;
        });
};