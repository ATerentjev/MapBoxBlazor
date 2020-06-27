var path = require("path");
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');



module.exports = {
  entry: ['./src/main.js','./src/main.css' ],
    output: {
        path: path.resolve(__dirname, '../../wwwroot/dist'),
        filename: "MapBoxBlazor.js"
  },
  module: {
    rules: [
			  {
				test: /\.js$/,
				use: {
				  loader: "babel-loader",
				  options: {

				  }
				}
			  },
				{
					test: /\.css$/,
        use: [
			  MiniCssExtractPlugin.loader,
			  {
				loader: "css-loader" // translates CSS into CommonJS
			  },
			]
		  }	
			]
		},
      plugins: [
            new MiniCssExtractPlugin({
				filename: 'MapBoxBlazor.css',
			path: path.resolve(__dirname, '../../wwwroot/dist')
    }),
    ]
};
