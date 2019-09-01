const jwt = require('jsonwebtoken');
const config = require('config');

module.exports = function(req, res, next){
    // Get token from the header
    const token = req.header('x-auth-token');

    // Check if no token
    if (!token) {
        return res.status(401).json({ msg: 'No Token, authorization denied!'});
    }

    try {
        // Verify the token
        const decoded = jwt.verify(token, config.get('jwtSecret'));
        // Get the user
        req.user = decoded.user;
        next();
    } catch {
        res.status(401).json({ msg: 'Token is not valid!'});
    }
}