const CopyWebpackPlugin = require('copy-webpack-plugin');

module.exports = {
    configureWebpack: {
		plugins: [
			new CopyWebpackPlugin([
				{
					from: 'src/i18n/countries.json',
					to: 'i18n',
					toType: 'dir',
				},
			]),
		],
	},
}