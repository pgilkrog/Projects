const express = require('express');
const router = express.Router();
const { check, validationResult } = require('express-validator');
const bcrypt = require('bcryptjs');
const jwt = require('jsonwebtoken');
const config = require('config');

const User = require('../models/User');

//@desc Remove Favorite from User
router.delete('/favorite/:userId/:musicianId', async (req, res) => {
    const { musicianId, userId } = req.params;

    User.updateMany(
        {_id: userId},
        { $pull : { "favorites": musicianId } },
        function(err, doc) {
            if(err){
                console.log(err);
            } else {
                res.json({ msg: "Favorite Removed!"});
            }
        }
    );
});

//@desc Add Favorite to User
router.put('/favorite', async (req, res) => {
    const { musicianId, userId } = req.body;

    User.findByIdAndUpdate(userId,
        {$push: {favorites: musicianId}},
        {save: true, upsert: true},
        function(err, doc) {
            if(err) {
                console.log(err);
            } else {
                res.json({ msg: "Favorite Added!" })
            }
        }
    );
});

//@desc POST user
router.post('/', [
    check('name', 'Please add name')
        .not()
        .isEmpty(),
    check('email', 'Please include a valid email').isEmail(),
    check('password', 'Please insert a password with 6 or more letters').isLength({ min: 6})
], async (req, res) => {
    const errors = validationResult(req);

    if(!errors.isEmpty()) {
        return res.status(400).json({ errors: errors.array() });
    }

    const { name, email, password, favorites } = req.body;

    try {
        // Look for user with email
        let user = await User.findOne({ email });

        if(user) {
            return res.status(400).json({ msg: 'User already exists'});
        }

        user = new User({
            name,
            email,
            password,
            favorites: []
        });

        // Generate a hashed password
        const salt = await bcrypt.genSalt(10);
        user.password = await bcrypt.hash(password, salt);

        // Save new user
        await user.save();

        const payload = {
            user: {
                id: user.id
            }
        }

        const id = user.id;

        // Make a json web token
        jwt.sign(payload, config.get('jwtSecret'), {
            expiresIn: 3600
        }, (err, token) => {
            if(err){
                throw err;
            }
            res.json({ token, id });
        })
    } catch (err) {
        console.error(err.message);
        res.status(500).send('server error');
    }
});

module.exports = router;