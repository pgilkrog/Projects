const express = require('express');
const connectDB = require('./config/db');

const app = express();

// Connect to the Database
connectDB();

// Init the middlewarte
app.use(express.json({ extended: false }));

app.get('/', (req, res) =>
    res.json({ msg: 'Welcome to the Vintage API!'})
);

// allow access to /images
app.use("/images", express.static("./images"));

// CORS
app.use((req, res, next) => {
    res.setHeader("Access-Control-Allow-Origin", "*");
    res.setHeader("Access-Control-Allow-Headers",
        "Origin, X-Requested-With, Content-Type, Accept, Authorization");
    res.setHeader("Access-Control-Allow-Methods",
        "GET, POST, PATCH, DELETE, OPTIONS, PUT");
    next();
});

// Define Routes
app.use('/api/users', require('./routes/users'));
app.use('/api/auth', require('./routes/auth'));
app.use('/api/musician', require('./routes/musician'));

const PORT = process.env.PORT || 5000;

app.listen(PORT, () => console.log(`Server started on port ${PORT}`));