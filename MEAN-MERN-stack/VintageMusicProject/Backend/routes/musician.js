const express = require('express');
const router = express.Router();
const extractFile = require('../middleware/fileMulter');

const Musician = require('../models/Musician');

//@desc Get all musicians
router.get('/', async (req, res) => {
    try{
        const fetchedmusicians = await Musician.find({});
        res.json({ musicians: fetchedmusicians });
    } catch(err) {
        console.error(err.message);
        res.status(500).send('server error');
    }
});

//desc Get random musicians
router.get('/random', async (req, res) => {
    try {
        const fetchedmusicians = await Musician.aggregate([{
            $sample: { size: 3 }
        }]);
        res.json({ musicians: fetchedmusicians });
    } catch (err) {
        console.error(err.message);
        res.status(500).send('Server error');
    }
});

//@desc Get musician by ID
router.get('/:id', async (req, res) => {
    try {
        const musician = await Musician.findById(req.params.id);
        res.json({ musician });
    } catch(err) {
        console.error(err.message);
        res.status(500).send('Server error');
    }
});

//@desc Create a musician
router.post('/', extractFile, async (req, res, next) => {
    const { name, realname, description, birth, death } = req.body;
    const url = req.protocol + '://' + req.get("host");

    try{
        newMusician = new Musician({
            name,
            realname,
            description,
            image: url + '/images/' + req.file.filename,
            birth,
            death
        });

        const musician = await newMusician.save();
        res.json(musician);

    } catch (err) {
        console.error(err.message);
        res.status(500).send('server error');
    }
});

module.exports = router;