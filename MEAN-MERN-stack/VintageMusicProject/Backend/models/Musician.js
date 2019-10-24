const mongoose = require('mongoose');

const MusicianScheme = mongoose.Schema({
    name: {
        type: String
    },
    realname: {
        type: String
    },
    description: {
        type: String
    },
    image: {
        type: String,
        default: 'http://localhost:5000/images/defaultImg.png'
    },
    birth: {
        type: Date
    },
    death: {
        type: Date
    }
});

module.exports = mongoose.model('musician', MusicianScheme);