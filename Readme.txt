Khi build webpack nhận lỗi : 
Invalid options object. PostCSS Loader has been initialized using an options object that does not match the API schema.

=> Xử lý 
npm uninstall postcss-loader --save-dev
npm install postcss-loader@~3.0.0 --save-dev