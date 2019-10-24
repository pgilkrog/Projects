const express = require('express');
const router = express.Router();
const { check, validationResult } = require('express-validator');
const bcrypt = require('bcryptjs');
const jwt = require('jsonwebtoken');
const config = require('config');
const auth = require('../middleware/auth');

const User = require('../models/User');

//@desc Get user by ID
router.get('/:id', async (req, res) => {
    try {
        const user = await User.findById(req.params.id);
        res.json({user});
    } catch {
        res.status(500).send('Server error');
    }
});

//@desc Get user and send it back
router.post('/', [
    check('email', 'Please include a valid email').isEmail(),
    check('password', 'Password is required').exists(),
], async (req, res) => {
    const errors = validationResult(req);
 
    if (!errors.isEmpty()) {
        return res.status(400).json({ errors: errors.array() });
    }

    const { email, password } = req.body;

    try {
        // Find a user with email
        let user = await User.findOne({ email });
        if (!user){
            return res.status(400).json({ msg: 'Invalid credentials' });
        }

        // Check if passwords match eachother
        const isMatch = await bcrypt.compare(password, user.password);
        if(!isMatch) {
            return res.status(400).json({ msg: 'Invalid credentials' });
        }

        const payload = {
            user: {
                id: user.id
            }
        }

        const id = user.id;

        // Make a json web token
        jwt.sign(payload, config.get('jwtSecret'), {
            expiresIn: 3500
        }, (err, token) => {
            if(err){
                throw err;
            }
            res.json({ token, id });
        });
    } catch {
        console.error(err.message);
        res.status(500).send('server error');
    }
});

module.exports = router;