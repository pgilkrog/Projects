const express = require("express");

const checkAuth = require('../middleware/check-auth');
const PostController = require('../controllers/postController');
const ectractFile = require('../middleware/fileMulter');

const router = express.Router();

router.post("", checkAuth, ectractFile, PostController.createPost);

router.get("", PostController.getAllPosts);

router.put("/:id", checkAuth, ectractFile, PostController.updatePost);

router.delete("/:id", checkAuth, PostController.deletePost);

router.get("/:id", PostController.getPostById);

module.exports = router;