const express = require('express');
const bodyparser = require("body-parser");
const mongoose = require("mongoose");
const path = require("path");

const postsRoutes = require("./routes/posts");
const userRoutes = require("./routes/user");

const app = express();

mongoose.set('useNewUrlParser', true);
mongoose.set('useFindAndModify', false);
mongoose.set('useCreateIndex', true);
mongoose.connect("mongodb+srv://max:" + process.env.MONGO_ATLAS_PW + "@cluster0-fpopi.mongodb.net/node-angular?retryWrites=true&w=majority")
.then(() => {
    console.log('Connected to database!');
})
.catch(() => {
    console.log('Connection failed!');
});

app.use(bodyparser.json());
app.use(bodyparser.urlencoded({ extended: false }));
    // allow access to /images
app.use("/images", express.static("./images"));

app.use((req, res, next) => {
    res.setHeader("Access-Control-Allow-Origin", "*");
    res.setHeader("Access-Control-Allow-Headers",
        "Origin, X-Requested-With, Content-Type, Accept, Authorization");
    res.setHeader("Access-Control-Allow-Methods",
        "GET, POST, PATCH, DELETE, OPTIONS, PUT");
    next();
});

app.use("/api/posts", postsRoutes);
app.use("/api/user", userRoutes);

module.exports = app;

// hNr6IBqAnvyX4wF0