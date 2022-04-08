const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/weatherforecast",
    "/doctor",
    "/patient",
    "/medication",
    "/vitalinformation"
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'https://localhost:7279',
        secure: false
    });

    app.use(appProxy);
};
