const express = require('express');
const router = express.Router();
const { check, validationResult } = require('express-validator');
const bcrypt = require('bcryptjs');
const jwt = require('jsonwebtoken');
const config = require('config');

const User = require('../models/User');

// @route       POST api/users
// @desc        Register a user
// @access      Public
router.post('/', [
    check('name', 'Please add name')
        .not()
        .isEmpty(),
    check('email', 'Please include a valid email').isEmail(),
    check('password', 'Please insert a password with 6 or more letters')
        .isLength({ min: 6})
], 
async (req, res) => {
    const errors = validationResult(req);
    if (!errors.isEmpty()) {
        return res.status(400).json({ errors: errors.array() });
    }

    const { name, email, password} = req.body;

    try {
        // Look for user with email
        let user = await User.findOne({ email });

        // If user exists return status 400
        if (user) {
            return res.status(400).json({ msg: 'User already exists'});
        }

        user = new User({
            name,
            email,
            password
        });

        // Generate a hashed password
        const salt = await bcrypt.genSalt(10);
        user.password = await bcrypt.hash(password, salt);

        // Save the new user
        await user.save();

        const payload = {
            user: {
                id: user.id
            }
        }

        // Make a json web token
        jwt.sign(payload, config.get('jwtSecret'), {
            expiresIn: 3600
        }, (err, token) => {
            if (err) {
                throw err;
            }
            res.json({ token });
        });

    } catch (err) {
        console.error(err.message);
        res.status(500).send('server error');
    }
});

module.exports = router;